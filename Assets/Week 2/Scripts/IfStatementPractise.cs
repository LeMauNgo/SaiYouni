using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

public class IfStatementPractise : MonoBehaviour
{
    private void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // Kiểm tra số dương, âm, hoặc bằng 0
        BaiTap2(); // Kiểm tra số chẵn hay lẻ
        BaiTap3(); // Kiểm tra điều kiện thi đỗ
        BaiTap4(); // Tìm số lớn nhất trong hai số
        BaiTap5(); // Kiểm tra điều kiện mua hàng
        BaiTap6(); // Kiểm tra năm nhuận
        BaiTap7(); // Tính giá vé xem phim
        BaiTap8(); // Kiểm tra học sinh xuất sắc
        BaiTap9(); // So sánh ba số
        BaiTap10(); // Tính tiền lương
        BaiTap11(); // Kiểm tra điều kiện vào câu lạc bộ
        BaiTap12(); // Phân loại học sinh
        BaiTap13(); // Tính tiền điện
        BaiTap14(); // Kiểm tra điều kiện thăng chức
        BaiTap15(); // Kiểm tra điều kiện miễn phí vận chuyển
        BaiTap16(); // Tính thuế thu nhập cá nhân
        BaiTap17(); // Tính điểm trung bình của môn học
        BaiTap18(); // Kiểm tra điều kiện nhập hàng
        BaiTap19(); // Tìm số lớn hơn 10
        BaiTap20(); // Kiểm tra điều kiện đăng ký khóa học
    }

    // Bài Tập 1: Kiểm Tra Số Dương, Âm Hoặc Bằng 0
    void BaiTap1()
    {
        Debug.Log("---------- 1 -----------");
        // Nhập một số từ bàn phím
        int i = 5;
        // Kiểm tra xem số đó là số dương, âm hay bằng 0
        if (i == 0) 
        {
            Debug.Log(i + " La so 0");
        }else if (i > 0)
        {
            Debug.Log(i + " La so duong");
        }
        else
        {
            Debug.Log(i + " La so am");
        }
    }

    // Bài Tập 2: Kiểm Tra Số Chẵn Hay Lẻ
    void BaiTap2()
    {
        Debug.Log("---------- 2 -----------");
        // Nhập một số từ bàn phím
        int i = 7;
        // Kiểm tra xem số đó là số chẵn hay lẻ
        if (i % 2 == 0)
        {
            Debug.Log(i + " La so chan");
        }else if (i % 2 != 0)
        {
            Debug.Log(i + " La so le");
        }
    }

    // Bài Tập 3: Kiểm Tra Điều Kiện Thi Đỗ
    void BaiTap3()
    {
        Debug.Log("---------- 3 -----------");
        // Nhập điểm trung bình của học sinh từ bàn phím
        int score = 7;
        // Kiểm tra nếu điểm trung bình >= 5.0 thì học sinh đỗ, ngược lại thì trượt
        if(score >= 5)
        {
            Debug.Log("Pass");
        }
        else
        {
            Debug.Log("False");
        }
    }

    // Bài Tập 4: Tìm Số Lớn Nhất Trong Hai Số
    void BaiTap4()
    {
        Debug.Log("---------- 4 -----------");
        // Nhập hai số nguyên từ bàn phím
        int number1 = 5;
        int number2 = 10;

        // Kiểm tra và in ra số lớn nhất trong hai số đó
        if (number1 >= number2)
        {
            Debug.Log("Max = " + number1);
        }
        else
        {
            Debug.Log("Max = " + number2);
        }
    }
    // Bài Tập 5: Kiểm Tra Điều Kiện Mua Hàng
    void BaiTap5()
    {
        Debug.Log("---------- 5 -----------");
        // Nhập số tiền hiện có và giá sản phẩm từ bàn phím
        int money = 63;
        int price = 50;
        // Kiểm tra xem người dùng có đủ tiền mua hàng không
        if (money >= price)
        {
            Debug.Log("Đủ");
        }
        else
        {
            Debug.Log("Không đủ");
        }
    }

    // Bài Tập 6: Kiểm Tra Năm Nhuận
    void BaiTap6()
    {
        Debug.Log("---------- 6 -----------");
        // Nhập một năm từ bàn phím
        int year = 2024;
        // Kiểm tra xem năm đó có phải là năm nhuận hay không
        if (year % 4 == 0)
        {
            Debug.Log(year + "Là năm nhuận");
        }
        else
        {
            Debug.Log(year + "Không phải năm nhuận");
        }
    }

    // Bài Tập 7: Tính Giá Vé Xem Phim
    void BaiTap7()
    {
        Debug.Log("---------- 7 -----------");
        // Nhập tuổi của người mua vé từ bàn phím
        int old = 20;
        // Nếu người mua dưới 18 tuổi, giá vé là 50,000 đồng
        // Nếu người mua từ 18 tuổi trở lên, giá vé là 100,000 đồng

        if (old < 18)
        {
            Debug.Log("50k");
        }
        else
        {
            Debug.Log("100k");
        }
    }

    // Bài Tập 8: Kiểm Tra Học Sinh Xuất Sắc
    void BaiTap8()
    {
        Debug.Log("---------- 8 -----------");
        // Nhập điểm trung bình của học sinh từ bàn phím
        float score = 9.3f;
        // Kiểm tra xem học sinh có đạt danh hiệu xuất sắc không (điểm trung bình >= 9.0)
        if(score >= 9)
        {
            Debug.Log("Xuất xắc");
        }
        else
        {
            Debug.Log("CHưa xuất sắc");
        }
    }

    // Bài Tập 9: So Sánh Ba Số
    void BaiTap9()
    {
        Debug.Log("---------- 9 -----------");

        // Nhập ba số nguyên từ bàn phím
        int number1 = 7;
        int number2 = 2;
        int number3 = 8;
        // Kiểm tra và in ra số lớn nhất trong ba số đó
        if(number1 > number2 && number1 > number3)
        {
            Debug.Log("Max = " + number1);
        }
        if(number1 < number2 && number3 < number2)
        {
            Debug.Log("Max = " + number2);
        }
        if (number3 > number2 && number3 > number1)
        {
            Debug.Log("Max = " + number3);
        }
    }

    // Bài Tập 10: Tính Tiền Lương
    void BaiTap10()
    {
        Debug.Log("---------- 10 -----------");
        // Nhập số giờ làm việc và mức lương cố định từ bàn phím
        float workingHours = 45;
        float hourlyWage = 20;
        float overtimeRate = 1.5f;

        // Nếu nhân viên làm trên 40 giờ, lương được tính thêm giờ
        // Nếu làm dưới hoặc bằng 40 giờ, lương tính theo giờ cố định
        float totalSalary = 0.0f;

        if (workingHours > 40)
        {
            // Calculate regular pay for the first 40 hours and overtime for extra hours
            float overtimeHours = workingHours - 40;
            totalSalary = (40 * hourlyWage) + (overtimeHours * hourlyWage * overtimeRate);
            Debug.Log("Total Salary = " + totalSalary + "$");
        }
        else
        {
            // If worked 40 hours or less, calculate regular pay
            totalSalary = workingHours * hourlyWage;
            Debug.Log("Total Salary = " + totalSalary + "$");
        }
    }

    // Bài Tập 11: Kiểm Tra Điều Kiện Vào Câu Lạc Bộ
    void BaiTap11()
    {
        Debug.Log("---------- 11 -----------");
        // Nhập tuổi và kiểm tra xem người đó có thẻ thành viên hay không
        int old = 20;
        bool card = true;
        // Kiểm tra nếu trên 18 tuổi và có thẻ thành viên thì được vào câu lạc bộ
        if(old > 18 && card)
        {
            Debug.Log("Được vào");
        }
        else
        {
            Debug.Log("Không được vào");
        }
    }

    // Bài Tập 12: Phân Loại Học Sinh
    void BaiTap12()
    {
        Debug.Log("---------- 12 -----------");
        // Nhập điểm trung bình của học sinh từ bàn phím
        float score = 7.5f;

        // Phân loại học sinh theo thang điểm từ xuất sắc đến yếu
        if(score >= 9)
        {
            Debug.Log("Xuất xắc");
        }else if(score >= 7)
        {
            Debug.Log("Khá");
        }else if(score >= 5)
        {
            Debug.Log("trung binh");
        }
        else
        {
            Debug.Log("yếu");
        }
    }

    // Bài Tập 13: Tính Tiền Điện
    void BaiTap13()
    {
        Debug.Log("---------- 13 -----------");
        // Nhập số điện tiêu thụ từ bàn phím
        int electronic = 370;
        // Tính tiền điện theo công thức: <= 100 kWh: 1,500 đồng/kWh, >100 kWh: 2,000 đồng/kWh
        float moneyElectronic;
        if(electronic <= 100)
        {
            moneyElectronic = electronic * 1500;
        }
        else
        {
            moneyElectronic = electronic * 2000;
        }
        Debug.Log(electronic);
    }

    // Bài Tập 14: Kiểm Tra Điều Kiện Thăng Chức
    void BaiTap14()
    {
        Debug.Log("---------- 14 -----------");
        // Nhập số năm làm việc và đánh giá công việc
        int year = 3;
        bool appreciat = true;
        // Kiểm tra nếu số năm làm việc trên 5 năm và đánh giá tốt thì đủ điều kiện thăng chức
        if(year >= 5 && appreciat)
        {
            Debug.Log("Thăng chức");
        }
        else
        {
            Debug.Log("Chưa đủ điều kiện");
        }
    }

    // Bài Tập 15: Kiểm Tra Điều Kiện Miễn Phí Vận Chuyển
    void BaiTap15()
    {
        Debug.Log("---------- 15 -----------");
        // Nhập giá trị đơn hàng từ bàn phím
        int price = 475000;
        // Kiểm tra nếu giá trị đơn hàng >= 500,000 đồng thì được miễn phí vận chuyển
        if( price >= 500000)
        {
            Debug.Log("Free ship");
        }
        else
        {
            Debug.Log("No Free ship");
        }
    }

    // Bài Tập 16: Tính Thuế Thu Nhập Cá Nhân
    void BaiTap16()
    {
        Debug.Log("---------- 16 -----------");
        // Nhập thu nhập từ bàn phím\
        float salary = 5000000;
        float tax;
        // Tính thuế thu nhập cá nhân dựa trên mức thu nhập
        tax = salary * 5 / 100;
        Debug.Log(tax);
    }

    // Bài Tập 17: Tính Điểm Trung Bình Của Môn Học
    void BaiTap17()
    {
        Debug.Log("---------- 17 -----------");
        // Nhập điểm của 3 bài kiểm tra từ bàn phím
        float Mathf = 7f;
        float physics = 4f;
        float chemistry = 2.5f;
        // Tính điểm trung bình và kiểm tra xem học sinh có đạt yêu cầu hay không (>= 5.0)
        float average = (Mathf + physics + chemistry) / 3;
        if(average >= 5)
        {
            Debug.Log("Đạt");
        }
        else
        {
            Debug.Log("Không đạt");
        }
    }

    // Bài Tập 18: Kiểm Tra Điều Kiện Nhập Hàng
    void BaiTap18()
    {
        Debug.Log("---------- 18 -----------");
        // Nhập số lượng hàng hiện tại và kiểm tra khả năng nhập thêm hàng (dưới 100 và còn chỗ)
        int numberGoods = 300;
        bool emty = false;
        if (numberGoods < 100 && emty)
        {
            Debug.Log("Nhập thêm");
        }
        else
        {
            Debug.Log("chưa nhập");
        }

    }

    // Bài Tập 19: Tìm Số Lớn Hơn 10
    void BaiTap19()
    {
        Debug.Log("---------- 19 -----------");
        // Nhập một số từ bàn phím
        int number = 35;
        // Kiểm tra xem số đó có lớn hơn 10 hay không
        if(number > 10)
        {
            Debug.Log(number + "Lớn hơn 10");
        }
        else
        {
            Debug.Log(number + "Bé hơn 10");
        }
    }

    // Bài Tập 20: Kiểm Tra Điều Kiện Đăng Ký Khóa Học
    void BaiTap20()
    {
        Debug.Log("---------- 20 -----------");
        // Nhập điểm tổng kết và các điều kiện khác từ bàn phím
        int score = 5;
        // Kiểm tra xem học sinh có đủ điều kiện đăng ký khóa học nâng cao không
        if(score >= 5)
        {
            Debug.Log("đủ");
        }
        else
        {
            Debug.Log("Chưa đủ");
        }
    }
}
