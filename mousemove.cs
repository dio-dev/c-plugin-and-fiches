 
Random rnd = new System.Random();
 
double x, x1, x2, x3, x4;
double y, y1, y2, y3, y4;
 
int x_mov=0;
int y_mov=0;
int height;
int width;
////////////////////////////////////////////
Tab tab = instance.MainTab;
Document doc = tab.MainDocument;
double t=0;
//////////////////////////////
Point[] points = new Point[15000];
int[] delay = new int[15000];
int qwerty=0;
/////////////////////////////////////
Point Point1 = instance.ActiveTab.FullEmulationMouseCurrentPosition;
height = doc.Height;
width  = doc.Width;
 
x1=rnd.Next(10,width);
x2=rnd.Next(10,width);
x3=rnd.Next(10,width);
x4=rnd.Next(10,width);
 
y1=rnd.Next(10,950);
y2=rnd.Next(10,950);
y3=rnd.Next(10,950);
y4=rnd.Next(10,950);
for (int ii=0; ii<10; ii++)  //кол-во повторений рандомных петелек
{
        x1=x4;
        x2=rnd.Next(10,width);
        x3=rnd.Next(10,width);
        x4=rnd.Next(10,width);
 
        y1=y4;
        y2=rnd.Next(10,1050);
        y3=rnd.Next(10,1050);
        y4=rnd.Next(10,1050);
     
        int del = rnd.Next(6,10); //задержки движения от точки к точке
        for (int tt=0; tt<50; tt++)
        {
            t = (System.Convert.ToDouble(tt))/50;
            qwerty++;              
            x = (((1-t)*(1-t)*(1-t)*x1) + (3*(1-t)*(1-t)*t*x2) + (3*(1-t)*t*t*x3) + (t*t*t*x4));      
            y = (((1-t)*(1-t)*(1-t)*y1) + (3*(1-t)*(1-t)*t*y2) + (3*(1-t)*t*t*y3) + (t*t*t*y4));
             
            x_mov= System.Convert.ToInt32(x);
            y_mov= System.Convert.ToInt32(y);          
         
            delay [qwerty]= (del);
            points [qwerty] = new Point(x_mov, y_mov);
        }
}
 
instance.ActiveTab.MouseMove(points, delay, false, false);