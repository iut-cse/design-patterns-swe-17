using System.Text;

namespace DesignPatterns._00_Mohayemin.Reports
{
    public interface IRenderable
    {
        void Render(StringBuilder builder);
    }
}
