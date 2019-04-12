# Repo cho kĩ thuật lập trình

Danh sách các bài nằm trong file `TODO.md`

# Yêu cầu
Cài đặt `mono` hoặc `.NET`, cài 1 trong 2 để lấy cái `msc` là được. Nếu dùng `mono` thì có thêm `REPL` để test code trực tiếp trên terminal khá tiện.

# Cách compile và chạy
```sh
mcs source-code.cs
```

Nếu dùng `Visual Studio` thì compile xong nó tự chạy,  còn nếu dùng `mono` thì:

```sh
mono <output-file.exe>
```

Với những bài có dùng `BigInteger`, cần ref tới `System.Numerics.dll` (chưa test lệnh này trên `Visual Studio`, nhưng đại khái là cũng cần ref, cách làm có trên Google).

```sh
mcs /reference:System.Numerics.dll
```

# Nội dung thi giữa kì
- Bài toán n chữ số PI
- Bài toán cái túi (tham lam)
