using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class work
    {
        
        
        public void puzzle ()
        {
            string result = "";

            int x = 3;

            while (x > 0)
            {
                if (x > 2)
                {
                    result = result + "a";
                }

                x = x -1;
                result = result + "-";

                if (x == 2)
                {
                    result = result + "b c";
                }

                x = x - 1;
                result = result + "-";

                if (x == 1)
                {
                    result = result + "d";
                    x = x - 1;
                }
                MessageBox.Show(result);
            }
        }

        public void puzzleinpool()
        {
            int x = 0;
            string Poem = "";

            while ( x < 1)
            {
                Poem = Poem + "a ";
                if (x < 1)
                {
                    Poem = Poem + "noise ";
                }

                x = x + 2;

                if (x > 0)
                {
                    Poem = Poem + "annoys ";
                    x = x - 1;
                }

                if (x == 1)
                {
                    Poem = Poem + "an";
                }

                if (x < 4)
                {
                    Poem = Poem + "oyster";
                }
                x = x + 1;
            }
            MessageBox.Show(Poem);

        }
    }
}
