using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace U100
{
    class RegiuneMain
    {
        private unsafe static bool culoriCareSePotrivesc(uint* pixelPtr, Color culoare, int toleranta)
        {
            if (toleranta < 0) toleranta = 0;

            //Converteste pointeri de de la pixeli in culoare
            byte a = (byte)(*pixelPtr >> 24);
            byte r = (byte)(*pixelPtr >> 16);
            byte g = (byte)(*pixelPtr >> 8);
            byte b = (byte)(*pixelPtr >> 0);
            Color pointer = Color.FromArgb(a, r, g, b);

            //Fiecare valoare dintre doua culori nu poate diferi mai mult decat toleranta data 
            return Math.Abs(culoare.A - pointer.A) <= toleranta &&
                   Math.Abs(culoare.R - pointer.R) <= toleranta &&
                   Math.Abs(culoare.G - pointer.G) <= toleranta &&
                   Math.Abs(culoare.B - pointer.B) <= toleranta;
        }
                
        public unsafe static Region descoperaRegiunea(Bitmap bitmap, Color culoareTransparenta, int toleranta)
        {
            //Granitele
            GraphicsUnit unitate = GraphicsUnit.Pixel;
            RectangleF granitaF = bitmap.GetBounds(ref unitate);
            Rectangle granita = new Rectangle((int)granitaF.Left, (int)granitaF.Top,
                                             (int)granitaF.Width, (int)granitaF.Height);

            int yMax = (int)granitaF.Height;
            int xMax = (int)granitaF.Width;

            //Verificam toleranta
            if (toleranta <= 0) toleranta = 1;

            //Blocam imaginea
            BitmapData bitmapData = bitmap.LockBits(granita, ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            uint* pixelPtr = (uint*)bitmapData.Scan0.ToPointer();

            //Retine toate dreptunghiurile pentru regiune
            GraphicsPath forma = new GraphicsPath();

            //Cauta linii in imagine care nu au culoarea pe care dorim sa o eliminam
            for (int y = 0; y < yMax; y++)
            {
                byte* basePos = (byte*)pixelPtr;
                for (int x = 0; x < xMax; x++, pixelPtr++)
                {
                    //Daca mai extista culoare pe care sa o facem transparenta continuam
                    if (culoriCareSePotrivesc(pixelPtr, culoareTransparenta, toleranta))
                        continue;
                    //Linie de start
                    int x0 = x;
                    //Gaseste urmatorul pixel cu culoarea pe care trebuie sa o facem transparenta
                    while (x < xMax && !culoriCareSePotrivesc(pixelPtr, culoareTransparenta, toleranta))
                    {
                        x++;
                        pixelPtr++;
                    }
                    //Adauga linia sub forma de dreptunghi
                    forma.AddRectangle(new Rectangle(x0, y, x - x0, 1));
                }
                //Merge la linia urmatoare
                pixelPtr = (uint*)(basePos + bitmapData.Stride);
            }
            //Creeaza regiunea
            Region outputRegion = new Region(forma);     
            //Curata
            forma.Dispose();
            bitmap.UnlockBits(bitmapData);
            return outputRegion;
        }

    }
}
