﻿using Chess.Core.Pieces;
using Newtonsoft.Json;

namespace Chess.Core
{
    public class Board
    {
        #region delegates / events

        //event is called on main form constructor
        //public delegate void PieceMovedDelegate();
        //public event PieceMovedDelegate? OnPieceMoved;

        public delegate void GameOver(King? kingThatIsChecked, string message);
        public event GameOver? OnKingChecked;

        #endregion

        #region fields

        const int DEFAULT_SIZE = 8;

        private Tile[,] _tiles;
        public Stack<Tuple<Piece, Tile, Tile>> MoveStack = new Stack<Tuple<Piece, Tile, Tile>>();
        private string _latestMove = "";

        #endregion

        #region props

        public Tile[,] Tiles { get { return _tiles; } set { _tiles = value; } }
        public int Size { get; set; }

        public List<Piece> WhiteCapturedPieces { get; set; } = new List<Piece>();
        public List<Piece> BlackCapturedPieces { get; set; } = new List<Piece>();


        #endregion

        #region constructor

        // default constructor
        public Board(int size, bool addDefaultPieces)
        {
            _tiles = new Tile[size, size];
            Size = size;
            CreateTiles(size, size);

            if (addDefaultPieces)
                AddDefaultPieces();
        }
         
        // overload to allow custom board
        public Board(Tile[,] tiles)
        {
            _tiles = tiles;
        }

        // for json serialization
        [JsonConstructor]
        public Board() { }

        ~Board() => System.Diagnostics.Debug.WriteLine($"Chessboard was disposed");

        #endregion

        private void CreateTiles(int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    _tiles[i, j] = new Tile(i, j);
                }
            }
        }

        public void AddDefaultPieces()
        {
            //loop through each tile in 2d array and add pieces to board tiles
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i == 1)
                        _tiles[i, j].Piece = new Pawn('b', i, j); // adds 8 player black pawns to 2nd row
                    if (i == 6)
                        _tiles[i, j].Piece = new Pawn('w', i, j); // adds 8 white pawns to 7th row

                    // player 1's backrow
                    if (i == 7)
                    {
                        if (j == 0 || j == 7)
                            _tiles[i, j].Piece = new Rook('w', i, j); // adds both white rooks
                        if (j == 1 || j == 6)
                            _tiles[i, j].Piece = new Knight('w', i, j); // adds both white knights
                        if (j == 2 || j == 5)
                            _tiles[i, j].Piece = new Bishop('w', i, j); // adds both white bishops
                        if (j == 3)
                            _tiles[i, j].Piece = new Queen('w', i, j); // adds white queen
                        if (j == 4)
                            _tiles[i, j].Piece = new King('w', i, j); // adds white king
                    }

                    // player 2's backrow
                    if (i == 0)
                    {
                        if (j == 0 || j == 7)
                            _tiles[i, j].Piece = new Rook('b', i, j); // adds both black rooks
                        if (j == 1 || j == 6)
                            _tiles[i, j].Piece = new Knight('b', i, j); // adds both black knights
                        if (j == 2 || j == 5)
                            _tiles[i, j].Piece = new Bishop('b', i, j); // adds both black bishops
                        if (j == 3)
                            _tiles[i, j].Piece = new Queen('b', i, j); // adds black queen
                        if (j == 4)
                            _tiles[i, j].Piece = new King('b', i, j); // adds black king
                    }
                }
            }
        }

        // will return false until a valid move is made
        public bool TryMakeMove(Tile? from, Tile? to)
        {
            // if there is no piece on the tile, return false
            if (from.Piece is null) return false;

            from.Piece.GetValidMoves(this);

            // check if the move is valid
            if (Movement.MoveIsValid(this, from, to))
            {
                // return false if tiles are the same color
                if (from.Piece.Color == to.Piece?.Color) return false;
                // return false if the target piece is a king
                if (to.Piece is King) return false;

                MovePiece(from, to);

                if (IsKingInCheck(to.Piece, out King? king))
                {
                    OnKingChecked?.Invoke(king, "Check");

                    //if (king.GetValidMoves(this).Count == 0)
                    //{
                    //    OnKingChecked?.Invoke(king, "Checkmate");
                    //}
                    //else
                    //{
                    //    OnKingChecked?.Invoke(king, "Check");
                    //}
                }

                return true;
            }

            return false;
        }

        private void MovePiece(Tile from, Tile to)
        {
            to.Piece = from.Piece;
            to.Piece.CurrentLocation = new BoardLocation(to.Row, to.Column);

            from.Piece = null;
        }

        // create a method to check if the king is in check
        public bool IsKingInCheck(IPiece attackerPiece, out King? king)
        {
            var attackerMoves = attackerPiece.GetValidMoves(this).ToList();

            // if a move contains an enemy king
            foreach (var move in attackerMoves)
            {
                var tile = GetTile(move.Row, move.Column);
                if (tile == null) continue;

                if (tile.Piece is King && attackerPiece.Color != tile.Piece.Color)
                {
                    king = (King)move.Piece;
                    return true;
                }
            }

            king = null;
            return false;
        }

        public void UpdatePieces()
        {
            var tasks = new List<Task>();

            foreach (Tile tile in _tiles)
            {
                if (tile.Piece != null)
                tasks.Add(Task.Run(() => tile.Piece.GetValidMoves(this)));
            }

            Task.WaitAll(tasks.ToArray());
        }
        
        #region reset board

        public void ResetBoard()
        {
            throw new NotImplementedException();
        }

        #endregion

        // place custom piece on tile
        public IPiece AddPiece<T>(int row, int col, char color) where T : IPiece, new()
        {
            if (row >= Size || col >= Size)
                throw new IndexOutOfRangeException("Row or column is out of range.");

            T piece = new T();
            piece.CurrentLocation = new BoardLocation(row, col);
            //piece.GetValidMoves(this);
            piece.Color = color;
            _tiles[row, col].Piece = piece;
            return piece;
        }

        public IPiece? GetPiece(int row, int col)
        {
            return _tiles[row, col].Piece ?? null;
        }

        public void PlaceTile(int row, int col, Piece? piece = null)
        {
            _tiles[row, col] = new Tile(row, col, piece);
        }

        public Tile? GetTile(int row, int col)
        {
            try
            {
                return _tiles[row, col];
            }
            catch { return null; }
        }

        // get tile by piece
        public Tile? GetTileByPiece(IPiece piece)
        {
            foreach (Tile tile in _tiles)
            {
                if (tile.Piece == piece)
                    return tile;
            }
            return null;
        }


    }
}
