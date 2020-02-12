using System.Text;

namespace DesignPatterns.Reports
{
    public interface IRenderable
    {
        void Render(StringBuilder builder);
    }
}