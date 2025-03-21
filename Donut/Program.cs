                        using System;/*sssssssssssss*/
                    namespace Donut{class Program{/*ssss*/
                static void Main(){Console.WindowHeight = 31;
            Console.WindowWidth = 80;float A = 0, B = 0;/*ss*/
           float[] z = new float[1760];char[] b = new char[1760];
        Console.Clear(); while (true){  Array.Fill(b, ' ');/*ss*/
        Array.Fill(z, 0); for (float j = 0; j < 6.28; j += 0.07f){
      /*ss*/for (float i = 0;          i < 6.28; i += 0.02f)/*sss*/
     /*ss*/{float c = /*ss*/             /**/MathF.Sin(i);float d =
    /*s*/MathF.Cos(j);float              e = MathF.Sin(A);float f// 
    =  MathF.Sin(j);float                 g = MathF.Cos(A); float h 
    = d + 2; float D = 1                / (c * h * e + f * g + 5);//
    float l =/*ssssssss*/                 MathF.Cos(i);float m =/**/ 
     MathF.Cos(B);float n              = MathF.Sin(B); float t =/// 
      c * h * g - f * e; int          x = (int)(40 + 30 * D * (l *
       h * m - t * n)); int y=     (int)(12 + 15 * D * (l * h * n
        + t * m)); int o = x + 80 * y; int N = (int)(8 * ((f *//
          e - c * d * g) * m - c * d * e - f * g - l * d *///
           n)); if (22 > y && y > 0 && x > 0 &&  80 > x &&// 
             D > z[o]) { z[o] = D;b[o] =".,-~:;=!*#$@"///
               [N > 0 ? N : 0];}}}/*sssssssssssssss*///
                Console.SetCursorPosition(0, 0);/**/
                   Console.Write(b);A += 0.04f;///
                      B += 0.08f;}}}}/*ssss*////
                        ////////////////////