using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.SocialPlatforms.Impl;

public class ORPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // Kiểm tra vé vào cửa
        BaiTap2(); // Điều kiện trúng thưởng
        BaiTap3(); // Kiểm tra điều kiện vay tiền
        BaiTap4(); // Điều kiện nhận học bổng
        BaiTap5(); // Kiểm tra đăng ký sự kiện
        BaiTap6(); // Điều kiện lái xe
        BaiTap7(); // Kiểm tra quyền truy cập tài liệu
        BaiTap8(); // Kiểm tra điều kiện tham gia khóa học
        BaiTap9(); // Điều kiện tải ứng dụng miễn phí
        BaiTap10(); // Điều kiện sử dụng dịch vụ đặc biệt
    }

    // Bài Tập 1: Kiểm Tra Vé Vào Cửa
    void BaiTap1()
    {
        bool carMember = true;
        bool vipMember = true;
        if(carMember || vipMember)
        {
            Debug.Log("Pass");
        }
    }

    // Bài Tập 2: Điều Kiện Trúng Thưởng
    void BaiTap2()
    {
        // Kiểm tra xem người dùng có trúng thưởng nếu số vé của họ trúng giải nhất, nhì, hoặc ba
        int prize = 2;
        if (prize == 1 || prize == 2 || prize == 3)
        {
            Debug.Log("you have won");
        }

    }

    // Bài Tập 3: Kiểm Tra Điều Kiện Vay Tiền
    void BaiTap3()
    {
        // Kiểm tra xem người dùng có đủ điều kiện vay tiền nếu có thu nhập ổn định, tài sản thế chấp, hoặc người bảo lãnh
        bool stableIncome = true;
        bool collateral = true;
        bool guarantor = false;
        if(collateral || guarantor || stableIncome)
        {
            Debug.Log("eligible");
        }
    }

    // Bài Tập 4: Điều Kiện Nhận Học Bổng
    void BaiTap4()
    {
        // Kiểm tra xem học sinh có nhận được học bổng nếu có thành tích học tập xuất sắc, hoạt động ngoại khóa tốt, hoặc gia đình khó khăn
        bool academicAchievement = true;
        bool extracurricularActivitie = true;
        bool disadvantagedFamily = true;
        if( extracurricularActivitie || academicAchievement || disadvantagedFamily)
        {
            Debug.Log("eligible");
        }
    }

    // Bài Tập 5: Kiểm Tra Đăng Ký Sự Kiện
    void BaiTap5()
    {
        // Kiểm tra xem người dùng có thể đăng ký sự kiện nếu có email hợp lệ, số điện thoại xác thực, hoặc đã đăng ký qua trang web
        bool email = true;
        bool numberPhone = false;
        bool signupWeb = false;
        if(email || numberPhone || signupWeb)
        {
            Debug.Log("Login succer");
        }

    }

    // Bài Tập 6: Điều Kiện Lái Xe
    void BaiTap6()
    {
        bool hasValidEmail = true;  
        bool hasVerifiedPhone = false;  
        bool registeredViaWebsite = false;
        if (hasValidEmail || hasVerifiedPhone || registeredViaWebsite)
        {
            Debug.Log("This person can register for the event.");
        }
    }

    // Bài Tập 7: Kiểm Tra Quyền Truy Cập Tài Liệu
    void BaiTap7()
    {
        bool hasDriverLicense = true;      
        bool hasValidRegistration = false;  
        bool hasInsurance = false;          

        if (hasDriverLicense || hasValidRegistration || hasInsurance)
        {
            Console.WriteLine("This person can drive.");
        }
    }

    // Bài Tập 8: Kiểm Tra Điều Kiện Tham Gia Khóa Học
    void BaiTap8()
    {
        // Kiểm tra xem học sinh có thể tham gia khóa học đặc biệt nếu có thư giới thiệu từ giáo viên, đã hoàn thành bài kiểm tra đầu vào, hoặc có kinh nghiệm liên quan
        bool hasRecommendationLetter = true; 
        bool hasPassedEntranceExam = false;    
        bool hasRelevantExperience = false;     

        if (hasRecommendationLetter || hasPassedEntranceExam || hasRelevantExperience)
        {
            Console.WriteLine("This student can take a special course.");
        }
    }

    // Bài Tập 9: Điều Kiện Tải Ứng Dụng Miễn Phí
    void BaiTap9()
    {
        // Kiểm tra xem người dùng có thể tải ứng dụng miễn phí nếu có mã khuyến mãi, là thành viên VIP, hoặc ứng dụng đang trong thời gian miễn phí
        bool hasPromoCode = true;       
        bool isVIPMember = false;       
        bool isFreePeriod = false;      

        if (hasPromoCode || isVIPMember || isFreePeriod)
        {
            Console.WriteLine("Users can download the application for free.");
        }
    }

    // Bài Tập 10: Điều Kiện Sử Dụng Dịch Vụ Đặc Biệt
    void BaiTap10()
    {
        // Kiểm tra xem khách hàng có thể sử dụng dịch vụ đặc biệt nếu đã chi tiêu trên mức yêu cầu, là khách hàng thân thiết, hoặc có chương trình khuyến mãi
        bool hasSpentAboveRequirement = true;  
        bool isLoyalCustomer = false;          
        bool hasPromotion = false;            
        if (hasSpentAboveRequirement || isLoyalCustomer || hasPromotion)
        {
            Console.WriteLine("Customers can use special services.");
        }
    }
}
