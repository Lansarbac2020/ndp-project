// IGameElement.cs
using System;
using System.Drawing;
using System.Windows.Forms;

namespace kacisOyunu
{
    public interface IGameElement
    {
        void HandleKeyPress(KeyEventArgs e);
        void Update();
        void Reset();
        

        // Default or dummy implementation for Bounds
        Rectangle Bounds { get; }
    }
}
