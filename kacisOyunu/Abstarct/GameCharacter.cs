using kacisOyunu.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public abstract class GameCharacter
{
    public PictureBox PictureBox { get; set; }
    public abstract void Move(Direction direction);
    // Add other common properties and methods
}


