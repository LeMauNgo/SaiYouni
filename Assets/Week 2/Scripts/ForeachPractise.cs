using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class ForeachPractise : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // In tất cả các phần tử trong mảng
        BaiTap2(); // Tính tổng các phần tử trong mảng
        BaiTap3(); // Tìm phần tử lớn nhất trong mảng
        BaiTap4(); // Đếm số lượng số chẵn trong mảng
        BaiTap5(); // In tất cả các chuỗi trong danh sách
        BaiTap6(); // Tìm chuỗi dài nhất trong danh sách
        BaiTap7(); // Tính tổng các số lẻ trong mảng
        BaiTap8(); // In các số chẵn trong mảng
        BaiTap9(); // Kiểm tra sự tồn tại của một phần tử trong mảng
        BaiTap10(); // Đếm số phần tử âm trong mảng
        BaiTap11(); // In các số lớn hơn 10 trong mảng
        BaiTap12(); // Tìm chuỗi có độ dài ngắn nhất trong danh sách
        BaiTap13(); // Nhân đôi tất cả các phần tử trong mảng
        BaiTap14(); // Tìm số lớn thứ hai trong mảng
        BaiTap15(); // Tìm chuỗi bắt đầu bằng chữ cái A
        BaiTap16(); // Kiểm tra danh sách có chứa chuỗi "Hello" không
        BaiTap17(); // In tất cả các phần tử âm trong mảng
        BaiTap18(); // Đếm số lần xuất hiện của một phần tử trong mảng
        BaiTap19(); // Tạo danh sách mới từ các phần tử lớn hơn 10
        BaiTap20(); // In các chuỗi có độ dài lớn hơn 5 ký tự
    }
    // Bài Tập 1: In Tất Cả Các Phần Tử Trong Mảng
    void BaiTap1()
    {
        Debug.Log("---------- 1 -----------");
        // Tạo một mảng số nguyên
        int[] numbers = { 2, 3, 15, 7, 4 };
        // Sử dụng foreach để in tất cả các phần tử trong mảng
        foreach (int i in numbers)
        {
            Debug.Log(i);
        }
    }

    // Bài Tập 2: Tính Tổng Các Phần Tử Trong Mảng
    void BaiTap2()
    {
        Debug.Log("---------- 2 -----------");
        // Tạo một mảng số nguyên
        int[] numbers = { 2, 3, 15, 7, 4 };
        int sum = 0;
        // Sử dụng foreach để tính tổng tất cả các phần tử trong mảng
        foreach (int i in numbers)
        {
            sum += i;
        }
        Debug.Log("total num ber = " + sum);
    }

    // Bài Tập 3: Tìm Phần Tử Lớn Nhất Trong Mảng
    void BaiTap3()
    {
        Debug.Log("---------- 3 -----------");
        // Tạo một mảng số nguyên
        int[] numbers = { 2, 3, 15, 7, 4 };
        int max = numbers[0];
        // Sử dụng foreach để tìm phần tử lớn nhất trong mảng
        foreach (int i in numbers)
        {
            if (max >= i) continue;
            max = i;
        }
        Debug.Log("Max numbers = " + max);
    }

    // Bài Tập 4: Đếm Số Lượng Số Chẵn Trong Mảng
    void BaiTap4()
    {
        Debug.Log("---------- 4 -----------");
        // Tạo một mảng số nguyên
        int[] numbers = { 2, 3, 15, 7, 4 };
        int countEvenNumber = 0;
        // Sử dụng foreach để đếm số lượng phần tử chẵn trong mảng
        foreach (int i in numbers)
        {
            if ((i % 2) != 0) continue;
            countEvenNumber++;
        }
        Debug.Log("Total Event Number In Char = " + countEvenNumber);
    }

    // Bài Tập 5: In Tất Cả Các Chuỗi Trong Danh Sách
    void BaiTap5()
    {
        Debug.Log("---------- 5 -----------");
        // Tạo một danh sách các chuỗi
        List<string> stringList = new List<string>();

        stringList.Add("Apple");
        stringList.Add("Banana");
        stringList.Add("Avocado");
        stringList.Add("Cherry");
        stringList.Add("Apricot");
        // Sử dụng foreach để in tất cả các chuỗi trong danh sách
        foreach (string str in stringList)
        {
            Debug.Log($"{str}");
        }
    }

    // Bài Tập 6: Tìm Chuỗi Dài Nhất Trong Danh Sách
    void BaiTap6()
    {
        Debug.Log("---------- 6 -----------");
        // Tạo một danh sách các chuỗi
        List<string> stringList = new List<string>();
        string longestString = "";

        stringList.Add("Apple");
        stringList.Add("Banana");
        stringList.Add("Avocado");
        stringList.Add("Cherry");
        // Sử dụng foreach để tìm chuỗi dài nhất trong danh sách
        foreach(string str in stringList)
        {
            if (longestString.Length >= str.Length) continue;
            longestString = str;
        }
        Debug.Log(longestString);
    }

    // Bài Tập 7: Tính Tổng Các Số Lẻ Trong Mảng
    void BaiTap7()
    {
        Debug.Log("---------- 7 -----------");
        // Tạo một mảng số nguyên
        int[] numbers = { 2, 3, 15, 7, 4 };
        int sumOddNumber = 0;
        // Sử dụng foreach để tính tổng tất cả các số lẻ trong mảng
        foreach (int i in numbers)
        {
            if ((i % 2) == 0) continue;
            sumOddNumber += i;
        }
        Debug.Log("Sum Odd Number = " + sumOddNumber);
    }

    // Bài Tập 8: In Các Số Chẵn Trong Mảng
    void BaiTap8()
    {
        Debug.Log("---------- 8 -----------");
        // Tạo một mảng số nguyên
        int[] numbers = { 2, 3, 15, 7, 4 };

        // Sử dụng foreach để in tất cả các số chẵn trong mảng
        foreach (int i in numbers)
        {
            if ((i % 2) != 0) continue;
            Debug.Log("even Number in char = " + i);
        }
    }

    // Bài Tập 9: Kiểm Tra Sự Tồn Tại Của Một Phần Tử Trong Mảng
    void BaiTap9()
    {
        Debug.Log("---------- 9 -----------");
        // Tạo một mảng số nguyên và một phần tử cần kiểm tra
        int[] numbers = { 2, 3, 15, 7, 4 };
        int numberCheck = 9;
        int count = 0;
        // Sử dụng foreach để kiểm tra xem phần tử đó có tồn tại trong mảng không
        foreach (int i in numbers)
        {
            if (numberCheck != i) continue;
            count++;
            Debug.Log(numberCheck + " in char");
        }
        if (count == 0)
        {
            Debug.Log(numberCheck + " not in char");
        }
    }

    // Bài Tập 10: Đếm Số Phần Tử Âm Trong Mảng
    void BaiTap10()
    {
        Debug.Log("---------- 10 -----------");
        // Tạo một mảng số nguyên
        int[] numbers = { 2, 3, -15, -7, 4 };
        int countNegativeNumber = 0;
        // Sử dụng foreach để đếm số lượng các phần tử âm trong mảng
        foreach (int i in numbers)
        {
            if (i >= 0) continue;
            countNegativeNumber++;
        }
        Debug.Log("number negative Number" + countNegativeNumber);
    }

    // Bài Tập 11: In Các Số Lớn Hơn 10 Trong Mảng
    void BaiTap11()
    {
        Debug.Log("---------- 11 -----------");
        // Tạo một mảng số nguyên
        int[] numbers = { 2, 3, 15, -7, 4, 21 };
        // Sử dụng foreach để in các số lớn hơn 10 trong mảng
        foreach (int i in numbers)
        {
            if (i <= 10) continue;
            Debug.Log(i + " Bigger 10 ");
        }
    }

    // Bài Tập 12: Tìm Chuỗi Có Độ Dài Ngắn Nhất Trong Danh Sách
    void BaiTap12()
    {
        // Tạo một danh sách các chuỗi
        Debug.Log("---------- 12 -----------");
        List<string> stringList = new List<string>();
        

        stringList.Add("Apple");
        stringList.Add("Banana");
        stringList.Add("Avocado");
        stringList.Add("Cherry");

        string shoterString = stringList[3];
        // Sử dụng foreach để tìm chuỗi có độ dài ngắn nhất trong danh sách
        foreach (string str in stringList)
        {
            if (shoterString.Length <= str.Length) continue;
            shoterString = str;
        }
        Debug.Log(shoterString);
    }

    // Bài Tập 13: Nhân Đôi Tất Cả Các Phần Tử Trong Mảng
    void BaiTap13()
    {
        Debug.Log("---------- 13 -----------");
        // Tạo một mảng số nguyên
        int[] numbers = { 2, 3, 15, -7, 4, 21 };
        int[] numbersx2 = new int[numbers.Length];
        int j = 0;

        // Sử dụng foreach để nhân đôi tất cả các phần tử trong mảng
        foreach (int i in numbers)
        {
            numbersx2[j] = i*2;
            j++;
        }
        foreach (int i in numbersx2)
        {
            Debug.Log(i);
        }
    }

    // Bài Tập 14: Tìm Số Lớn Thứ Hai Trong Mảng
    void BaiTap14()
    {
        Debug.Log("---------- 14 -----------");

        int[] numbers = { 2, 3, 15, -7, 4, 21 };
        // Tạo một mảng số nguyên
        int max = numbers[0];
        int maxSecon = numbers[0];
        foreach (int i in numbers)
        {
            if (max >= i) continue;
            max = i;
        }

        // Sử dụng foreach để tìm phần tử lớn thứ hai trong mảng
        foreach (int i in numbers)
        {
            if (maxSecon >= i || i == max) continue;
            maxSecon = i;
        }
        Debug.Log(maxSecon);
    }

    // Bài Tập 15: Tìm Chuỗi Bắt Đầu Bằng Chữ Cái A
    void BaiTap15()
    {
        // Tạo một danh sách các chuỗi
        Debug.Log("---------- 15 -----------");
        List<string> stringList = new List<string>();


        stringList.Add("Apple");
        stringList.Add("Banana");
        stringList.Add("Avocado");
        stringList.Add("Cherry");
        // Sử dụng foreach để tìm và in các chuỗi bắt đầu bằng chữ cái 'A'
        foreach (string str in stringList)
        {
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] != 'A') break;
                Debug.Log(str);
            }
        }
    }

    // Bài Tập 16: Kiểm Tra Xem Danh Sách Có Chứa Một Chuỗi Cụ Thể Không
    void BaiTap16()
    {
        // Tạo một danh sách các chuỗi
        Debug.Log("---------- 15 -----------");
        List<string> stringList = new List<string>();


        stringList.Add("Apple");
        stringList.Add("Banana");
        stringList.Add("Avocado");
        stringList.Add("Cherry");
        string strCheck = "Hello";
        int count = 0;
        // Sử dụng foreach để kiểm tra xem danh sách có chứa chuỗi "Hello" hay không
        foreach (string str in stringList)
        {
            if (str != strCheck) continue;
            count++;
        }
        if(count == 0)
        {
            Debug.Log("No string Hello");
        }
        else
        {
            Debug.Log("Yes string Hello");
        }
    }

    // Bài Tập 17: In Tất Cả Các Phần Tử Âm Trong Mảng
    void BaiTap17()
    {
        Debug.Log("---------- 17 -----------");
        // Tạo một mảng số nguyên
        int[] numbers = { 2, -3, 15, -7, 4, 21 };

        // Sử dụng foreach để in ra tất cả các phần tử âm trong mảng
        foreach (int i in numbers)
        {
            if (i >= 0) continue;
            Debug.Log(i);
        }
    }

    // Bài Tập 18: Đếm Số Lần Xuất Hiện Của Một Phần Tử Trong Mảng
    void BaiTap18()
    {
        Debug.Log("---------- 18 -----------");
        // Tạo một mảng số nguyên và một phần tử cụ thể
        int[] numbers = { 2, -3, 15, -7, 4, 21, 4, 4 };
        int number = 4;
        int countNumber = 0;
        // Sử dụng foreach để đếm số lần xuất hiện của phần tử cụ thể đó trong
        foreach(int i in numbers)
        {
            if( i !=  number) continue;
            countNumber++; 
        }
        Debug.Log("count Number 4 = " + countNumber);
    }

    // Bài Tập 19: Tạo Một Danh Sách Mới Từ Các Phần Tử Lớn Hơn 10 Trong Mảng
    void BaiTap19()
    {
        Debug.Log("---------- 19 -----------");
        // Tạo một mảng số nguyên
        int[] numbers = { 2, -3, 15, -7, 4, 21, 41, 14 };
        List<int> listNumber = new List<int>();
        // Sử dụng foreach để tạo một danh sách mới chứa các phần tử có giá trị lớn hơn 10
        foreach (int i in numbers)
        {
            if(i<=10 ) continue;
            listNumber.Add(i);
        }
        foreach (int i in listNumber)
        {
            Debug.Log(i);
        }
    }

    // Bài Tập 20: In Các Chuỗi Có Độ Dài Lớn Hơn 5 Ký Tự
    void BaiTap20()
    {
        Debug.Log("---------- 20 -----------");
        // Tạo một danh sách các chuỗi

        List<string> stringList = new List<string>();

        stringList.Add("Ape");
        stringList.Add("Banana");
        stringList.Add("Avocado");
        stringList.Add("Chry");
        // Sử dụng foreach để in các chuỗi có độ dài lớn hơn 5 ký tự
        foreach (string str in stringList)
        {
            if (str.Length <= 5) continue;
            Debug.Log(str);
        }
    }

}
