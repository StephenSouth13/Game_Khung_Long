🕹️ Dino Runner - Game Platformer 2D
🚀 Giới thiệu
Dino Runner là một trò chơi platformer side-scrolling 2D thú vị nơi bạn điều khiển một chú khủng long vượt qua các chướng ngại vật, thu thập xu và tránh kẻ thù. Game được xây dựng với Unity 6.0.1 sử dụng hệ thống Input System mới, animation nhân vật, tương tác vật lý và hiệu ứng hình ảnh mượt mà.

📸 Screenshot
Chưa có ảnh? Bạn có thể thêm ảnh gameplay đẹp tại đây bằng cú pháp:
![Gameplay Screenshot](assets/screenshots/gameplay1.png)


🧩 Tính năng nổi bật
- 🎮 Di chuyển mượt mà với hệ thống Input System mới
- 📦 Sử dụng prefab linh hoạt cho các đối tượng: người chơi, enemy, coin
- 🌄 Hiệu ứng nền cuộn (parallax) tạo chiều sâu
- 🕊️ Animation với Animator Controller: chạy, nhảy, chết
- 💥 Tương tác vật lý: va chạm với Enemy, Coin, và sàn
- 🌟 Thu thập điểm số và hồi sinh (có thể thêm power-up tùy ý)

🧠 Yêu cầu hệ thống
| Thành phần | Phiên bản khuyến nghị | 
| Unity Editor | 6.0.1 | 
| Input System | 1.5 trở lên | 
| Platform | PC / WebGL / Android | 
| Hệ điều hành | Windows / macOS / Linux | 



📂 Cấu trúc thư mục
DinoRunner/
├── Assets/
│   ├── Scripts/
│   │   ├── PlayerController.cs
│   │   ├── EnemyController.cs
│   ├── Prefabs/
│   ├── Scenes/
│   ├── Sprites/
│   └── Input/
│       └── PlayerInput.inputactions
├── ProjectSettings/
└── README.md



🔧 Cách cài đặt và chạy
# Clone dự án về máy
git clone https://github.com/tenban/DinoRunner.git

# Mở bằng Unity 6.0.1
# Chạy scene chính có tên: MainScene.unity



⌨️ Điều khiển
| Hành động | Phím gán | 
| Di chuyển | ← / → hoặc A / D | 
| Nhảy | Spacebar | 
| Thoát game | Esc | 



📝 Ghi chú bổ sung
- Đảm bảo các object đã gán tag (Player, Enemy, Coin) để xử lý va chạm chính xác
- Sử dụng Rigidbody2D loại Dynamic, và Collider2D để tương tác vật lý
- Có thể mở rộng bằng cách thêm hệ thống âm thanh, particle, menu UI

📄 License
Dự án dùng cho mục đích cá nhân hoặc học tập
Vui lòng không sao chép hoặc sử dụng asset thương mại nếu không có quyền



