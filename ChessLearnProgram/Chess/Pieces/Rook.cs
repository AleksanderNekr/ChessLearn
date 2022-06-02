﻿using System.Drawing;
using System.Windows.Forms;

namespace Chess.Pieces
{
    public sealed class Rook : ChessPiece
    {
        public int Clicks = 0;

        public Rook(Coordinate coordinate, string color) : base(coordinate, color)
        {
            this.AllowDrop = true;
            this.Anchor    = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.AutoSize  = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = color == "Black"
                                       ? new Bitmap(ResourceBlack.Rook)
                                       : new Bitmap(ResourceWhite.Rook);

            this.BackgroundImageLayout      = ImageLayout.Zoom;
            this.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.FlatAppearance.BorderSize  = 0;
            this.FlatStyle                  = FlatStyle.Flat;
            this.ForeColor                  = System.Drawing.Color.DarkRed;
            this.Location                   = new Point(173, 347);
            this.Margin                     = new Padding(2);
            this.Name                       = "Queen";
            this.Size                       = new Size(53, 54);
            this.TabIndex                   = 7;
            this.UseVisualStyleBackColor    = true;
        }
    }
}
