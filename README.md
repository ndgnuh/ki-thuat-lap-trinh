# Repo cho kĩ thuật lập trình

## Mục lục
- [Yêu cầu](#yêu-cầu)
- [Hướng dẫn](#cách-compile-và-chạy)

Danh sách các bài nằm trong file `TODO.md`

## Yêu cầu
Cài đặt `mono` hoặc `.NET`, cài 1 trong 2 để lấy cái `msc` là được. Nếu dùng `mono` thì có thêm `REPL` để test code trực tiếp trên terminal khá tiện.

## Cách compile và chạy

### Với những người dùng Vs-code

Chỉ cần mở workspace có sẵn trong repo, chạy build task (dùng `Ctrl + Shift + b` hoặc vào `terminal > run build task`)

### Dùng terminal

```sh
mcs source-code.cs
```

Nếu dùng `Visual Studio` thì compile xong nó tự chạy,  còn nếu dùng `mono` thì:

```sh
mono <output-file.exe>
```

Với những bài có dùng `BigInteger`, cần ref tới `System.Numerics.dll` (chưa test lệnh này trên `Visual Studio`, nhưng đại khái là cũng cần ref, cách làm có trên Google).

```sh
mcs /reference:System.Numerics.dll source-code.cs
```

## Nội dung thi giữa kì
- Bài toán n chữ số PI
- Bài toán cái túi (tham lam)
