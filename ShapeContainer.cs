using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
    public class ShapeContainer
    {
        private static List<AbstractFigure> list;
        public ShapeContainer() {
            list = new List<AbstractFigure>();
        }

        public static void AddFigure(AbstractFigure figure)
        {
            list.Add(figure);
        }

        static public List<AbstractFigure> get_list()
        {
            return list;
        }



        public static void DelFigure(AbstractFigure figure, bool for_move)
        {

            Graphics g = Graphics.FromImage(Init.bitmap);
            g.Clear(Color.White);
            Init.picture_box.Image = Init.bitmap;

            list.Remove(figure);
            foreach (AbstractFigure f in list)
            {
                f.Draw();
            }

            if (for_move)
            {
                list.Add(figure);
            }

        }

        public static void DrawAll()
        {
            foreach (AbstractFigure f in list)
            {
                f.Draw();
            }
        }

    }
}
