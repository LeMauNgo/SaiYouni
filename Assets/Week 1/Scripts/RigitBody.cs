using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.NetworkInformation;
using UnityEngine;
using static Unity.Burst.Intrinsics.Arm;
using static Unity.Burst.Intrinsics.X86.Avx;
using UnityEngine.UIElements;
public class RigitBody : MonoBehaviour
{
    // Nhờ AI Giải Thích Về Rigidbody
                //    Rigidbody trong Unity là một thành phần(component) vật lý dùng để mô phỏng các hành vi vật lý thực tế như trọng lực, va chạm, ma sát, và lực tác động.Khi một đối tượng trong game được gắn Rigidbody, nó có thể được điều khiển bởi hệ thống vật lý của Unity thay vì chỉ di chuyển đơn thuần thông qua các phép tính thủ công.
                //    Các tính năng chính của Rigidbody:
                //Trọng lực(Gravity):
                //Khi bật tùy chọn trọng lực(default là bật), đối tượng sẽ chịu tác động của trọng lực và tự động rơi xuống nếu không có lực hoặc vật cản giữ lại.
                //    Ví dụ: Khi bạn thả một khối vuông từ trên cao, nó sẽ rơi xuống sàn do tác động của trọng lực.
                //Lực tác động(Force) :
                //Bạn có thể áp dụng các lực để di chuyển, đẩy, hoặc kéo đối tượng.Unity cho phép bạn sử dụng các phương thức như AddForce() để thêm lực lên đối tượng theo các hướng xác định.

                //Ví dụ: Dùng rb.AddForce(Vector3.up* 5) để đẩy đối tượng lên trên.
                //Va chạm (Collisions):
                //Khi một đối tượng có Rigidbody được gắn kèm với một Collider, nó sẽ có thể tương tác vật lý với các đối tượng khác trong scene, chẳng hạn như va chạm và dừng lại khi chạm vào đối tượng khác.

                //Ma sát và khối lượng (Mass and Drag):
                //Rigidbody cho phép bạn thiết lập khối lượng(mass) và ma sát(drag) của đối tượng.Khối lượng càng lớn thì cần nhiều lực hơn để di chuyển.Ma sát làm chậm dần tốc độ của đối tượng khi nó di chuyển trong không gian.

                //Kinematic vs Non-Kinematic:

                //Non-Kinematic: Mặc định, Rigidbody không kinematic sẽ chịu tác động của các lực vật lý như trọng lực và va chạm.
                //Kinematic: Khi Rigidbody được đặt là kinematic, nó sẽ không bị ảnh hưởng bởi hệ thống vật lý (không chịu trọng lực, không có va chạm tự động), nhưng bạn vẫn có thể di chuyển nó bằng cách thủ công qua script.
                //Freeze Position/Rotation:
                //Unity cung cấp tùy chọn "Freeze" để ngăn không cho đối tượng di chuyển hoặc xoay theo các trục nhất định, hữu ích khi bạn muốn kiểm soát hành vi của đối tượng trong game.

                //Ví dụ:
                //csharp
                //    Copy code
                //Rigidbody rb = GetComponent<Rigidbody>();
                //    rb.AddForce(Vector3.forward* 10);  // Đẩy đối tượng về phía trước với lực 10
                //Tổng Kết:
                //Rigidbody là công cụ cần thiết khi bạn muốn đối tượng của mình có các hành vi vật lý như di chuyển do trọng lực, phản ứng với lực tác động, và va chạm với các đối tượng khác.Nó giúp mô phỏng vật lý thực tế trong môi trường game mà không cần phải tính toán chi tiết thủ công.

    // tự tìm hiểu được
        /* 
          - rigitboy dùng để add lực cho vật thể, có 3 kiểu là kinamic, dynamic , static
            - dynamic là sẽ tác động cả nội lực và ngoại lực chgo vật thể, như lực hút, hay lực đẩy
            - kinamic sẽ chỉ tác động nội lực như velocity;
            - static sẽ không có tác dụng lực sẽ dùng cho vật thể bất đồng như cục gạch cục đá
            
        - các vật thể cần rigitbody để nhận va chạm, và tác động lực như ma sát,...
         */
}
