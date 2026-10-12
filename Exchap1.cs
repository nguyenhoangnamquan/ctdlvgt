using System.ComponentModel.DataAnnotations;

namespace MyProject;
class Exchap1
{
    static int timsonhonhat(int a, int b, int c)
    {
        int min = a;
        if (b<a)
        {
            min = b;
        }
        if (c<a)
        {
            min = c;
        }
        return min;
    }
    static int timsolonnhat (int a, int b, int c)
     {
        int max = a;
        if (b>a)
        {
            max = b;
        }
        if (c>a)
        {
            max = c;
        }
        return max;
    }
    static int tinhtong(int a, int b, int c)
    {
        int sum = a + b + c;
        return sum;
    }
    static double timtrungbinh(int a, int b, int c)
    {
        int sum = a + b + c;
        double trungbinh = sum/3;
        return trungbinh;
    }
    static void timgiatrilonnhatvalonthuhai(int[] mang)
      {
        int temp=0;
        int dem = 0;
        int sum = 0;
        int demin = 0;
        foreach (int ptu in mang)
        {
            sum = sum+ptu;
        }
        int trungbinh = sum/mang.Length;
        foreach (int tungcai in mang)
        {
            if (tungcai == trungbinh)
            {
                demin++;
                continue;
            }
            else
            {
                break;
            }
        }
        if (demin==mang.Length)
        {
            Console.WriteLine("NO");
        }
        else//sap xep tang dan = bubble sort
        {
             while (dem<mang.Length-1)
        {
            for (int i = 0; i<mang.Length-1; i++)
        {
           
            if (mang[i+1] < mang[i])
            {
                temp = mang[i];
                mang[i] = mang[i+1];
                mang[i+1] = temp;
            }
            else
            {
                dem++;
            }
        }
        }//in ra 2 gia tri cuoi
         Console.WriteLine($"So lon nhat: {mang[mang.Length-1]}");
        Console.WriteLine($"So lon thu hai: {mang[mang.Length-2]}");
        }

       
       
      }
      
      
static int TongLonNhat_PhienBanA(int[] mang)
{
    int max = mang[0];

    for (int i = 0; i < mang.Length; i++)
    {
        int tong = 0;

        for (int j = i; j < mang.Length; j++)
        {
            tong = tong + mang[j];

            if (tong > max)
            {
                max = tong;
            }
        }
    }

    return max;
}

static int TongLonNhat_PhienBanB(int[] mang)
{
    int tong = mang[0];
    int max = mang[0];

    for (int i = 1; i < mang.Length; i++)
    {
        if (tong + mang[i] < mang[i])
        {
            tong = mang[i];
        }
        else
        {
            tong = tong + mang[i];
        }

        if (tong > max)
        {
            max = tong;
        }
    }

    return max;
}




    public static void Main(string[] args)
    {
        int kq1 = timsolonnhat(7, 5, 3);
        int kq2 = timsonhonhat(7, 5, 3);
        int kq4 = tinhtong(7,5,3);
        double kq3 = timtrungbinh(7, 5, 3);
        Console.WriteLine($"Lon nhat: {kq1}");
        Console.WriteLine($"Nho nhat:{kq2}");
        Console.WriteLine($"Trung binh: {kq3:F2}");
        Console.WriteLine($"Tinh tong: {kq4}");
        timgiatrilonnhatvalonthuhai([9, 1, 7, 3, 5, 8]);
        int kq5 = TongLonNhat_PhienBanA([-2, 1, -3, 4, -1, 2, 1, -5, 4]);
        int kq6 = TongLonNhat_PhienBanB([-2, 1, -3, 4, -1, 2, 1, -5, 4]);
        Console.WriteLine($"Phien ban A: {kq5}");
        Console.WriteLine($"Phien ban B: {kq6}");
    }
}