using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mathf : MonoBehaviour
{
    //Hỏi AI Cách Chia Lấy Dư Một Số Bất Kỳ
    /* 
    Trong Unity C# (và nhiều ngôn ngữ lập trình khác), để chia lấy dư của một số bất kỳ, bạn sử dụng toán tử % (toán tử chia lấy dư). Toán tử này trả về phần dư sau khi chia một số cho số khác.

    Cú pháp:
    csharp
    Copy code
    int remainder = a % b;
    a: Số bị chia.
    b: Số chia.
    remainder: Phần dư của phép chia a / b.
    Ví dụ:
    csharp
    Copy code
    int a = 17;
    int b = 5;
    int remainder = a % b;  // remainder sẽ là 2
    Trong ví dụ trên, 17 chia cho 5 được 3 và dư 2, nên kết quả của remainder là 2.*/
    // Nội Dung Đã Tìm Hiểu
    // - a % b là phép chia lấy dư, được ứng dụng trong bài toán tìm chẵn lẻ hay là tìm số nguyên tố

    /* # 5 Kiểu Dữ Liệu Khác của Unity C#

## Giới Thiệu

    Ngoài các kiểu dữ liệu cơ bản như `int`, `float`, `bool`, và `string`, Unity C# còn hỗ trợ nhiều kiểu dữ liệu khác để giúp lập trình viên quản lý và xử lý dữ liệu hiệu quả hơn. Dưới đây là 5 kiểu dữ liệu khác mà bạn có thể sử dụng trong Unity C#.
     - double
    - vector2
    -vector3
    - list
     - char



    Ngoài các toán tử cơ bản như toán tử số học, toán tử quan hệ, và toán tử logic, Unity C# còn hỗ trợ nhiều toán tử khác để giúp lập trình viên thực hiện các thao tác phức tạp hơn. Dưới đây là 3 toán tử khác mà bạn có thể sử dụng trong Unity C#.


    Dưới đây là 3 toán tử khác trong Unity C# mà bạn có thể sử dụng ngoài các toán tử số học, quan hệ, và logic:

Toán tử điều kiện ba ngôi (?:)
Toán tử này được sử dụng để thay thế cho câu lệnh if-else, giúp đơn giản hóa việc kiểm tra điều kiện và trả về giá trị tương ứng. Cú pháp:

csharp
Copy code
condition ? value_if_true : value_if_false;
Ví dụ:

csharp
Copy code
int result = (a > b) ? a : b; // Nếu a > b thì result bằng a, ngược lại bằng b.
*Toán tử gán kết hợp (+=, -=, =, /=)
Các toán tử này kết hợp phép gán và phép toán số học, giúp rút gọn code.
Ví dụ:

csharp
Copy code
a += 5;  // Tương đương với a = a + 5;
b *= 2;  // Tương đương với b = b * 2;
Toán tử null-coalescing (??)
Toán tử này được dùng để trả về giá trị không null từ hai biểu thức. Nếu biểu thức đầu tiên là null, nó sẽ trả về giá trị của biểu thức thứ hai.
Ví dụ:

csharp
Copy code
string name = userName ?? "Guest"; // Nếu userName là null, name sẽ bằng "Guest".
Những toán tử này giúp viết mã ngắn gọn và hiệu quả hơn, đặc biệt khi xử lý các tình huống điều kiện hoặc gán giá trị.
    */
}
