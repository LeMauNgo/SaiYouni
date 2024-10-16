# Sử Dụng NavMesh Obstacle Trong Unity

## Hỏi AI: Cách Sử Dụng NavMesh Obstacle

### NavMesh Obstacle là gì?

**NavMesh Obstacle** là một thành phần trong Unity được sử dụng để tạo ra các vật cản trong môi trường, ngăn cản các nhân vật hoặc đối tượng điều hướng (navigation) qua những khu vực nhất định. Đối tượng được gắn **NavMesh Obstacle** sẽ trở thành vật cản và có thể tĩnh hoặc động, tùy thuộc vào cách bạn cấu hình nó.

### cấu hình NavMesh Obstacle
- cave: nhấn vào cave đối tượng vật cản sẽ liên tục cập nhật, cắt vào NavMesh
- shape: lựa chọn 2 dạng là capsule hoặc hình hộp.

### Chỉnh thông số caving
- Carving Move Threshold : đối tượng di chuyển 1 khoảng cách nhất định sẽ carve lại NavMesh
- Carving Time To Stationary: Đặt thời gian mà đối tượng cần đứng yên trước khi NavMesh Obstacle ngừng carve lại đường đi.

### Kiểm tra và điều chỉnh hệ thống **NavMesh** cho phù hợp với các vật cản mới.
- Kiểm tra NavMesh với các vật cản tĩnh
- Thiết lập và kiểm tra NavMesh Obstacle với tính năng Carving
- Điều chỉnh thông số của hệ thống NavMesh
- Test với các tác nhân AI (NavMesh Agents)
- Điều chỉnh Carving Move Threshold và Carving Time To Stationary