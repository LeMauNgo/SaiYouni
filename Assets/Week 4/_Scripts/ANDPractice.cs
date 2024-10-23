using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ANDPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // Kiểm tra tuổi, giấy phép, và kinh nghiệm
        BaiTap2(); // Kiểm tra điều kiện vào công viên giải trí
        BaiTap3(); // Điều kiện đạt học bổng
        BaiTap4(); // Kiểm tra đăng ký hợp lệ
        BaiTap5(); // Kiểm tra điều kiện thi lại
        BaiTap6(); // Xét tuyển nhân viên
        BaiTap7(); // Kiểm tra điều kiện mua hàng
        BaiTap8(); // Đủ điều kiện nhận phần thưởng
        BaiTap9(); // Kiểm tra điều kiện thăng chức
        BaiTap10(); // Điều kiện nhận vé miễn phí
    }

    // Bài Tập 1: Kiểm Tra Tuổi, Giấy Phép, Và Kinh Nghiệm
    void BaiTap1()
    {
        // Nhập tuổi, giấy phép lái xe, và kinh nghiệm lái xe
        // Kiểm tra nếu người dùng trên 18 tuổi, có giấy phép lái xe, và có kinh nghiệm trên 1 năm
        int old = 23;
        bool drivingLicense = false;
        int drivingExperience = 3;
        if (old > 18 && drivingLicense &&  drivingExperience > 1)
        {
            Debug.Log("this person can drive");
        }
        else
        {
            Debug.Log("this person can't drive");
        }
    }

    // Bài Tập 2: Kiểm Tra Điều Kiện Vào Công Viên Giải Trí
    void BaiTap2()
    {
        // Nhập thông tin về vé, đã đăng ký trước, và tiền sử bệnh tim
        // Kiểm tra nếu người dùng có vé, đã đăng ký trước, và không có tiền sử bệnh tim
        bool isTicket = true;
        bool isSignup = true;
        bool heartDisease = false;
        if (isTicket && isSignup && !heartDisease)
        {
            Debug.Log("this person eligible in to the park");
        }
        else
        {
            Debug.Log("this person can't in to the park");
        }

    }

    // Bài Tập 3: Điều Kiện Đạt Học Bổng
    void BaiTap3()
    {
        // Nhập điểm trung bình, điểm hoạt động ngoại khóa, và kiểm tra kỷ luật
        float averageScore = 8.5f;
        float extracurricularPoints = 8f;
        bool discipline = true;
        // Kiểm tra nếu điểm trung bình >= 9.0, điểm ngoại khóa >= 8.0, và không vi phạm kỷ luật
        if (averageScore >= 9 && extracurricularPoints >=8 && discipline)
        {
            Debug.Log("This student eligible for a scholarship");
        }
        else
        {
            Debug.Log(" This student is not eligible for a scholarship");
        }
    }

    // Bài Tập 4: Kiểm Tra Đăng Ký Hợp Lệ
    void BaiTap4()
    {
        // Nhập thông tin email, xác nhận qua điện thoại, và phí tham gia
        bool validEmail = true;
        bool ConfirmByPhone = true;
        bool participationFee =true;
        // Kiểm tra nếu email hợp lệ, đã xác nhận qua điện thoại, và đã thanh toán phí tham gia
        if (validEmail && ConfirmByPhone && participationFee)
        {
            Debug.Log("eligible");
        }
        else
        {
            Debug.Log("not eligible");
        }
    }

    // Bài Tập 5: Kiểm Tra Điều Kiện Thi Lại
    void BaiTap5()
    {
        // Nhập điểm tổng kết, số môn thi trượt, và điểm chuyên cần
        // Kiểm tra nếu điểm tổng kết < 5.0, số môn trượt <= 2, và điểm chuyên cần > 75%
        float summaryScore = 7f;
        int numberOfFailedSubjects = 1;
        float AttendancePoints = 1;
        if (summaryScore > 5 && numberOfFailedSubjects >= 2 && AttendancePoints > 0.75f)
        {
            Debug.Log("Pass");
        }
        else
        {
            Debug.Log("fail");
        }
    }

    // Bài Tập 6: Xét Tuyển Nhân Viên
    void BaiTap6()
    {
        // Nhập thông tin về bằng đại học, kinh nghiệm và bài kiểm tra năng lực
        // Kiểm tra nếu ứng viên đã tốt nghiệp đại học, có ít nhất 2 năm kinh nghiệm, và vượt qua bài kiểm tra năng lực
        bool hasUniversityDegree = true;
        bool hasAtLeastTwoYearsExperience = false;
        bool hasPassedCompetencyTest = true;

        if (hasUniversityDegree && hasAtLeastTwoYearsExperience && hasPassedCompetencyTest)
        {
            Debug.Log("candidate eligible");
        }
        else
        {
            Debug.Log("candidate not eligible.");
        }
    }

    // Bài Tập 7: Kiểm Tra Điều Kiện Mua Hàng
    void BaiTap7()
    {
        // Nhập số tiền hiện có, kiểm tra hàng trong kho và chương trình khuyến mãi
        // Kiểm tra nếu người dùng có đủ tiền, có hàng trong kho, và đủ điều kiện tham gia khuyến mãi
        double availableMoney = 100;
        bool isInStock = true;
        bool isEligibleForPromotion = true;

        if (availableMoney > 0 && isInStock && isEligibleForPromotion)
        {
            Debug.Log("This person eligible buy item");
        }
        else
        {
            Debug.Log("This person is not eligible buy item");
        }
    }

    // Bài Tập 8: Đủ Điều Kiện Nhận Phần Thưởng
    void BaiTap8()
    {
        // Nhập thông tin về nhiệm vụ hoàn thành, điểm trung bình nhiệm vụ, và đăng nhập hệ thống
        // Kiểm tra nếu đã hoàn thành ít nhất 10 nhiệm vụ, điểm nhiệm vụ >= 8, và đăng nhập vào hệ thống trong 7 ngày qua
        // Nhập thông tin từ người dùng
        int completedTasks = 15;
        double averageTaskScore = 10;
        bool loggedInLast7Days = true;

        if (completedTasks >= 10 && averageTaskScore >= 8 && loggedInLast7Days)
        {
            Debug.Log("Users are eligible to receive rewards");
        }
        else
        {
            Debug.Log("Users are not eleigible to receive rewards");
        }
    }

    // Bài Tập 9: Kiểm Tra Điều Kiện Thăng Chức
    void BaiTap9()
    {
        // Nhập số năm làm việc, chỉ tiêu công việc và vi phạm kỷ luật
        // Kiểm tra nếu đã làm việc trên 5 năm, đạt chỉ tiêu công việc và không vi phạm kỷ luật
        int yearsOfWork = 10;
        bool meetsJobTarget = true;
        bool hasDisciplinaryViolations = false;

        if (yearsOfWork > 5 && meetsJobTarget && !hasDisciplinaryViolations)
        {
            Debug.Log("this staff is eligible to Promote");
        }
        else
        {
            Debug.Log("this staff is not eligible to Promote");
        }
    }

    // Bài Tập 10: Điều Kiện Nhận Vé Miễn Phí
    void BaiTap10()
    {
        // Nhập tuổi, trạng thái thành viên VIP, và số lần mua vé trong năm
        // Kiểm tra nếu người dùng trên 60 tuổi, là thành viên VIP, và đã mua vé ít nhất 3 lần trong năm

        int age = 65;
        bool isVIPMember = false;
        int ticketsPurchased = 1;

        if (age > 60 || isVIPMember || ticketsPurchased >= 3)
        {
            Debug.Log("User is eligible receive free ticket.");
        }
        else
        {
            Debug.Log("User is not eligible receive free ticket.");
        }
    }
}
