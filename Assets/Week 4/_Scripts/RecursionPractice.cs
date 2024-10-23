using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecursionPractice : MonoBehaviour
{
    [Header("Bt1")]
    int factorial = 1;
    [Header("Bt2")]
    int n = 9;
    int total;
    [Header("Bt3")]
    int number = 7;
    // Start is called before the first frame update
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(7); // Tính giai thừa của một số
        BaiTap2(0); // Tính tổng các số từ 1 đến n
        Debug.Log(BaiTap3(7)); // Chuỗi Fibonacci
        BaiTap4(13); // Đếm ngược từ n về 1
        Debug.Log(BaiTap5(215,200)); // Tìm UCLN của hai số
    }

    // Bài Tập 1: Tính Giai Thừa Của Một Số
    void BaiTap1(int number)
    {
        // Nhập số nguyên dương n từ bàn phím
        // Viết hàm đệ quy để tính giai thừa của n
        if (number < 2) return;
        this.factorial *= number;
        //Debug.Log(factorial);
        this.BaiTap1(number - 1);
        
    }

    // Bài Tập 2: Tính Tổng Các Số Từ 1 Đến N
    void BaiTap2(int number)
    {
        // Nhập số nguyên dương n từ bàn phím
        // Viết hàm đệ quy để tính tổng các số từ 1 đến n
        if(number > this.n) return;
        this.total += number;
        //Debug.Log(total);
        this.BaiTap2(number + 1);
    }

    // Bài Tập 3: Chuỗi Fibonacci
    int BaiTap3(int number)
    {
        // Nhập số nguyên n từ bàn phím
        // Viết hàm đệ quy để tính số Fibonacci thứ n
        // Điều kiện dừng
        if (number == 1) return 0;
        if (number == 2) return 1;

        return BaiTap3(number - 1) + BaiTap3(number - 2);
    }

    // Bài Tập 4: Đếm Ngược
    void BaiTap4(int number)
    {
        // Nhập số nguyên n từ bàn phím
        // Viết hàm đệ quy để đếm ngược từ n về 1
        if(number < 1) return;
        Debug.Log(number);
        this.BaiTap4(number - 1);
    }

    // Bài Tập 5: Tìm UCLN (Ước Chung Lớn Nhất)
    int BaiTap5(int a, int b)
    {
        // Nhập hai số nguyên a và b từ bàn phím
        // Viết hàm đệ quy để tìm UCLN của hai số theo thuật toán Euclid
        if (b == 0) return a;

        return BaiTap5(b, a % b);
    }
}
