using kacisOyunu.Enum;
using System.Windows.Forms;

public interface IMovable
{
    PictureBox PictureBox { get; set; }
    void Move(Direction direction);
}
