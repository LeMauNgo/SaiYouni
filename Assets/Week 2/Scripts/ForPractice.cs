
using UnityEngine;

public class ForPractise : MonoBehaviour
{
    private void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // In Các Số Từ 1 Đến 100
        BaiTap2(); // Tính Tổng Các Số Từ 1 Đến 50
        BaiTap3(); // In Các Số Chẵn Từ 1 Đến 100
        BaiTap4(); // Tính Tích Các Số Từ 1 Đến 10
        BaiTap5(); // Tìm Số Lớn Nhất Trong Một Mảng
        BaiTap6(); // Tính Tổng Các Số Lẻ Từ 1 Đến 100
        BaiTap7(); // Đảo Ngược Chuỗi
        BaiTap8(); // In Ra Bảng Cửu Chương
        BaiTap9(); // Đếm Các Số Nguyên Dương Trong Mảng
        BaiTap10(); // In Tam Giác Số
        BaiTap11(); // Tìm Phần Tử Nhỏ Nhất Trong Mảng
        BaiTap12(); // In Dãy Fibonacci
        BaiTap13(); // Tính Giai Thừa Của Một Số
        BaiTap14(); // In Ra Các Số Nguyên Từ n Đến 1
        BaiTap15(); //  Tính Tổng Các Phần Tử Trong Mảng
        BaiTap16(); // Kiểm Tra Số Nguyên Tố
        BaiTap17(); // In Ra Dãy Số Chia Hết Cho 3
        BaiTap18(); // Tìm Tổng Các Số Chẵn Trong Mảng
        BaiTap19(); // Tính Trung Bình Cộng Của Mảng
        BaiTap20(); // Đếm Số Ký Tự Hoa Trong Chuỗi
    }

    // Bài Tập 1: In Các Số Từ 1 Đến 100
    void BaiTap1()
    {
        Debug.Log("---------- 1 -----------");
        // Viết một chương trình sử dụng vòng lặp **For** để in các số từ 1 đến 100.
        for (int i = 1; i <= 100; i++)
        {
            Debug.Log(i);
        }

    }

    // Bài Tập 2: Tính Tổng Các Số Từ 1 Đến 50
    void BaiTap2()
    {
        Debug.Log("---------- 2 -----------");
        int sum = 0;
        // Viết một chương trình sử dụng vòng lặp **For** để tính tổng các số từ 1 đến 50.
        for (int i = 1; i <= 50; i++) 
        { 
            sum += i;
        }
        Debug.Log(sum);
    }

    // Bài Tập 3: In Các Số Chẵn Từ 1 Đến 100
    void BaiTap3()
    {
        Debug.Log("---------- 3 -----------");
        // Viết một chương trình sử dụng vòng lặp **For** để in tất cả các số chẵn từ 1 đến 100.
        for (int i = 1;i <=100; i++) 
        {
            if (i % 2 != 0) continue;
            Debug.Log(i);
        }
    }

    // Bài Tập 4: Tính Tích Các Số Từ 1 Đến 10
    void BaiTap4()
    {
        Debug.Log("---------- 4 -----------");
        int product = 1;
        // Viết một chương trình sử dụng vòng lặp **For** để tính tích của các số từ 1 đến 10.
        for (int i = 1; i <= 10; i++)
        {
            product *= i;
        }
        Debug.Log(product);
    }

    // Bài Tập 5: Tìm Số Lớn Nhất Trong Một Mảng
    void BaiTap5()
    {
        Debug.Log("---------- 5 -----------");
        // Viết một chương trình sử dụng vòng lặp **For** để tìm số lớn nhất trong một mảng số nguyên.
        int[] numbers = { 2, 3, 15, 7, 4 };
        int z = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (z >= numbers[i]) continue;
            z = numbers[i];
        }
        Debug.Log("Max = " + z);
    }

    // Bài Tập 6: Tính Tổng Các Số Lẻ Từ 1 Đến 100
    void BaiTap6()
    {
        Debug.Log("---------- 6 -----------");
        int sum = 0;
        // Viết một chương trình sử dụng vòng lặp **For** để tính tổng các số lẻ từ 1 đến 100.
        for (int i = 1; i <= 100 ; i++)
        {
            if ((i % 2) == 0) continue;
            sum += i;
        }
        Debug.Log(sum);
    }

    // Bài Tập 7: Đảo Ngược Chuỗi
    void BaiTap7()
    {
        Debug.Log("---------- 7 -----------");
        string Str = "Hello";
        string NewStr = "";
        // Viết một chương trình sử dụng vòng lặp **For** để đảo ngược một chuỗi.
        for (int i = Str.Length - 1; i >=0; i--) 
        { 
            NewStr += Str[i];
        }
        Debug.Log(NewStr);
    }

    // Bài Tập 8: In Ra Bảng Cửu Chương
    void BaiTap8()
    {
        Debug.Log("---------- 8 -----------");
        // Viết một chương trình sử dụng vòng lặp **For** để in ra bảng cửu chương của một số bất kỳ (từ 1 đến 10).
        for(int i = 1;i <= 10; i++)
        {
            int product = i * 4;
            Debug.Log(i + " X 4 = " + product);
        }

    }

    // Bài Tập 9: Đếm Các Số Nguyên Dương Trong Mảng
    void BaiTap9()
    {
        Debug.Log("---------- 9 -----------");
        // Viết một chương trình sử dụng vòng lặp **For** để đếm số lượng các số nguyên dương trong một mảng số nguyên.
        int[] numbers = { 2, 3, -15, -7, 4 };
        int count = 0;
        for(int i =0 ; i < numbers.Length; i++)
        {
            if (numbers[i] >= 0) continue;
            count++;
        }
        Debug.Log(count);
    }

    // Bài Tập 10: In Tam Giác Số
    void BaiTap10()
    {
        Debug.Log("---------- 10 -----------");
        // Viết một chương trình sử dụng vòng lặp **For** để in ra một tam giác số như sau:
        for (int i = 1; i <= 5; i++)
        {
            string line = "";
            for (int j = 1; j <= i; j++)
            {
                line += j.ToString();
            }
            Debug.Log(line);
        }
    }

    // Bài Tập 11:Tìm Phần Tử Nhỏ Nhất Trong Mảng
    void BaiTap11()
    {
        Debug.Log("---------- 11 -----------");
        // Viết một chương trình sử dụng vòng lặp **For** để tìm phần tử nhỏ nhất trong một mảng số nguyên.
        int[] numbers = { 2, 3, -15, -7, 4 };
        int z = numbers[0];
        for (int i = 0 ; i < numbers.Length; i++)
        {
            if(z < numbers[i]) continue;
            z = numbers[i];
        }
        Debug.Log("Min number = " +  z);    
    }

    // Bài Tập 12: In Dãy Fibonacci
    void BaiTap12()
    {
        Debug.Log("---------- 12 -----------");
        // Viết một chương trình sử dụng vòng lặp **For** để in ra dãy Fibonacci từ 1 đến n (n là số nhập từ người dùng).
        int n = 8;
        int a = 0, b = 1, nexNumber;
        for (int i = 0; i < n; i++) 
        {
            Debug.Log(b);

            nexNumber = a + b;
            a = b;
            b = nexNumber;
        }

    }

    // Bài Tập 13: Tính Giai Thừa Của Một Số
    void BaiTap13()
    {
        Debug.Log("---------- 13 -----------");
        // Viết một chương trình sử dụng vòng lặp **For** để tính giai thừa của một số nguyên dương n.
        int i = 7;
        int product = 1;
        for (int j = 1; j <= i; j++)
        {
            product *= j;
        }
        Debug.Log(product);
    }

    // Bài Tập 14: In Ra Các Số Nguyên Từ n Đến 1
    void BaiTap14()
    {
        Debug.Log("---------- 14 -----------");
        // Viết một chương trình sử dụng vòng lặp **For** để in ra các số nguyên từ n đến 1, với n là số nhập từ người dùng.
        int number = 8;
        for (int i = number; i>= 1 ; i--)
        {
            Debug.Log(i);
        }
    }

    // Bài Tập 15: Tính Tổng Các Phần Tử Trong Mảng
    void BaiTap15()
    {
        Debug.Log("---------- 15 -----------");
        int[] numbers = { 2, 3, -15, -7, 4 };
        int sum = 0; 
        // Viết một chương trình sử dụng vòng lặp **For** để tính tổng các phần tử trong một mảng số nguyên.
        for (int i = 0; i < numbers.Length; i++) 
        {
            sum += numbers[i];
        }
        Debug.Log(sum);
    }

    // Bài Tập 16: Kiểm Tra Số Nguyên Tố
    void BaiTap16()
    {
        Debug.Log("---------- 16 -----------");
        //Viết một chương trình sử dụng vòng lặp **For** để kiểm tra xem một số nguyên có phải là số nguyên tố hay không.
        int number = 11;
        int count = 0;
        for (int i = 1 ; i <= number; i++)
        {
            if (number % i != 0) continue;
            count++;
        }
        if (count > 2)
        {
            Debug.Log(number + " Không phải là số nguyên tố");
        }
        else
        {
            Debug.Log(number + "là số nguyên tố");
        }
    }

    // Bài Tập 17: In Ra Dãy Số Chia Hết Cho 3
    void BaiTap17()
    {
        Debug.Log("---------- 17 -----------");
        // Viết một chương trình sử dụng vòng lặp **For** để in ra các số từ 1 đến 100 chia hết cho 3.
        for(int i = 1 ; i <= 100  ; i++)
        {
            if(i % 3 != 0) continue;
            Debug.Log(i);
        }
    }

    // Bài Tập 18: Tìm Tổng Các Số Chẵn Trong Mảng
    void BaiTap18()
    {
        Debug.Log("---------- 18 -----------");
        // Viết một chương trình sử dụng vòng lặp **For** để tính tổng các phần tử chẵn trong một mảng số nguyên.
        int[] numbers = { 2, 3, -15, -7, 4 };
        int sum = 0; 
        for (int i = 0; i < numbers.Length; i++) 
        {
            if (numbers[i] % 2 != 0) continue;
            sum += numbers[i];
        }
        Debug.Log(sum);
    }

    // Bài Tập 19: Tính Trung Bình Cộng Của Mảng
    void BaiTap19()
    {
        int[] numbers = { 2, 3, -15, -7, 4 };
        int sum = 0;
        float average = 0;
        Debug.Log("---------- 19 -----------");
        // Viết một chương trình sử dụng vòng lặp **For** để tính trung bình cộng của các phần tử trong một mảng số nguyên.
        for (int i = 0; i < numbers.Length; i++) 
        { 
            sum += numbers[i];
        }
        average = (float)sum/ numbers.Length;
        Debug.Log(average);
    }

    // Bài Tập 20: Đếm Số Ký Tự Hoa Trong Chuỗi
    void BaiTap20()
    {
        Debug.Log("---------- 20 -----------");
        // Viết một chương trình sử dụng vòng lặp **For** để đếm số lượng ký tự hoa trong một chuỗi.
        string inputString = "Hello Unity! How Are You Today?";
        int uppercaseCount = 0;

        for (int i = 0; i < inputString.Length; i++)
        {
            if (char.IsUpper(inputString[i]))
            {
                uppercaseCount++; 
            }
        }

        Debug.Log("Số lượng ký tự hoa trong chuỗi là: " + uppercaseCount);
    }
}
