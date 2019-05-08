# Repo cho kĩ thuật lập trình

## Mục lục
- [Yêu cầu](#yêu-cầu)
- [Hướng dẫn](#cách-compile-và-chạy)

Danh sách các bài nằm trong file `TODO.md`

## Yêu cầu
- `mono` hoặc `dotnet`

## Cách compile và chạy

Lưu ý: Hướng dẫn dưới đây dựa vào `mono`, những ai dùng `.NET` thì nên sửa `mcs` thành `csc`. Cả trong build task của `vscode` lẫn terminal.

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

## Nội dung thi cuối kì
Xem trong thư mục `cuoi-ki`, file `TODO.md`.
