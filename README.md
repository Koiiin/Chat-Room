# 💬 Chat Room App - C# Windows Forms (TCP Multi-Room Chat)

## 📝 Mô tả
Ứng dụng **Chat Room App** được xây dựng bằng C# Windows Forms, sử dụng giao thức **TCP** để tạo kết nối **client-server**, hỗ trợ:
- Đăng ký, đăng nhập người dùng.
- Tạo và tham gia nhiều phòng chat (multi-room).
- Gửi và nhận tin nhắn trong từng phòng.
- Giao diện thân thiện, dễ sử dụng.

Ứng dụng chia thành 3 thành phần chính:
- **Server Form**: Quản lý client, xử lý đăng nhập/đăng ký, phòng chat, truyền tin nhắn.
- **Client Form**: Giao diện chat của người dùng.
- **Menu Form**: Màn hình chọn khởi chạy server hoặc client.

---

## 📌 Tính năng chính

### 👤 Đăng ký và Đăng nhập
- Tài khoản được lưu trong `users.txt`.
- Hệ thống kiểm tra trùng username.
- Xác thực khi đăng nhập.

### 🧩 Quản lý phòng chat
- Tạo phòng bằng mã `RoomID` riêng biệt.
- Tham gia phòng có sẵn bằng `RoomID`.
- Chat trong phòng riêng tư.

### 💬 Trò chuyện thời gian thực
- Tin nhắn được gửi tới toàn bộ người trong cùng phòng.
- Tin nhắn hiển thị kèm timestamp.
- Hệ thống thông báo khi người dùng tham gia/thoát phòng.

### 🔐 Bảo mật cơ bản
- Kiểm tra quyền truy cập trước khi gửi tin nhắn.
- Từ chối hành động nếu chưa đăng nhập.

---

## 🛠️ Công nghệ sử dụng

- 💻 **Ngôn ngữ**: C#
- 📦 **Giao diện**: Windows Forms
- 🌐 **Mạng**: TCP/IP Socket
- 🗃️ **Lưu trữ người dùng**: File hoặc memory dictionary 

---

## 🛠 Cấu trúc dự án

                    ┌────────────────────────────┐
                    │        Server (TCP)        │
                    │  - Quản lý người dùng      │
                    │  - Quản lý phòng chat      │
                    │  - Truyền/nhận tin nhắn    │
                    └────────────┬───────────────┘
                                 │
              ┌──────────────────┼───────────────────────┐
              │                                          │
    ┌─────────▼──────────────┐               ┌───────────▼────────────┐
    │      Client 1          │               │       Client 2         │
    │  - Giao diện đăng nhập │               │  - Giao diện đăng nhập │
    │  - Gửi/nhận tin nhắn   │               │  - Gửi/nhận tin nhắn   │
    │  - Tạo/Tham gia phòng  │               │  - Tạo/Tham gia phòng  │
    └────────────────────────┘               └────────────────────────┘


- **Server**: Lắng nghe và xử lý nhiều client cùng lúc, quản lý người dùng, phòng chat và tin nhắn.
- **Client**: Giao diện người dùng để đăng nhập, chọn phòng, và trò chuyện.

---

## 🧩 Các chức năng chính

| Chức năng         | Mô tả                                                                |
|------------------|-----------------------------------------------------------------------|
| Đăng ký          | Tạo tài khoản mới (lưu vào `users.txt`)                               |
| Đăng nhập        | Kiểm tra thông tin người dùng đã đăng ký                              |
| Tạo phòng        | Người dùng tạo phòng mới với tên bất kỳ                               |
| Tham gia phòng   | Người dùng tham gia phòng chat có sẵn                                 |
| Gửi tin nhắn     | Gửi và nhận tin nhắn trong cùng phòng, giữa nhiều client              |
| Đăng xuất/Rời phòng | Tự động ngắt kết nối khi đóng ứng dụng                             |

---

## ▶️ Cách sử dụng

### 1. Build Menu:

- Mở `ChatRoom.sln` trong Visual Studio
- Chọn dự án **Menu.cs** và bấm **Start**

---

## 👤 Tác giả

- **Tên:** [Vũ Hoàng Khôi]
- **Email:** [23520792@gm.uit.edu.vn]
- **Github:** [https://github.com/Koiiin]
- **LAB 3:** Lập trình Sockets trong C# - Chat Room App

---

