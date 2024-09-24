using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86.Avx;

public class Array : MonoBehaviour
{
    //int[] scores = new int[10];`


            /* Dòng mã int[] scores = new int[10]; có nghĩa là:

        int[] – Đây là khai báo một mảng(array) của kiểu dữ liệu int. Mảng này sẽ chứa các giá trị kiểu số nguyên(int).

        scores – Tên của mảng, bạn có thể dùng tên này để truy cập và làm việc với các phần tử trong mảng.

        new int[10] – Phần này khởi tạo mảng mới gồm 10 phần tử kiểu int. Ban đầu, tất cả các phần tử trong mảng sẽ được gán giá trị mặc định là 0.

        Tổng quát:
        Mảng scores sẽ có 10 vị trí, và mỗi vị trí có thể chứa một giá trị số nguyên(int).
        Các phần tử trong mảng sẽ được đánh chỉ mục từ 0 đến 9. Ví dụ:
        scores[0] là phần tử đầu tiên của mảng.
        scores[9] là phần tử cuối cùng của mảng.
        Bạn có thể gán giá trị cho từng phần tử của mảng như sau:

        csharp
        Copy code
        scores[0] = 100; // Gán giá trị 100 cho phần tử đầu tiên
            scores[1] = 90;  // Gán giá trị 90 cho phần tử thứ hai
        Sau khi khai báo, bạn có thể thao tác trên từng phần tử của mảng thông qua chỉ mục(index). */
//## Nội Dung Đã Tìm Hiểu
    /*
      - đây là mảng gồm 10 phần tử kiểu dữ liệu int
      - khi tạo ra cả 10 phần tử sẽ có giá trị mặc định là = 0
      - khi muốn gán giá trị thì scores[0] = 1 thì giá trị vị trí thứ 1 trong mảng = 1, tương tự đến scores[9] = 21 thì vị trí thứ 10 = 21
      - khi tạo mảng thì các phần tử sẽ được tạo cố định, không thể thêm hoặc xóa đi phần tử nào, muốn thêm hay xóa thì dùng list
      - nên dùng khi dữ liệu ít bị thay đổi 
     */
}
