﻿namespace AlphaTab.Rendering.Glyphs
{
    public class ChineseCymbalGlyph : MusicFontGlyph
    {
        private readonly bool _isGrace;

        public ChineseCymbalGlyph(int x, int y, bool isGrace)
            : base(x, y, isGrace ? NoteHeadGlyph.GraceScale : 1, MusicFontSymbol.NoteHarmonic)
        {
            _isGrace = isGrace;
        }

        public override void DoLayout()
        {
            Width = (int)(9 * (_isGrace ? NoteHeadGlyph.GraceScale : 1) * Scale);
        }

        public override bool CanScale
        {
            get { return false; }
        }
    }
}
