# Repo cho kĩ thuật lập trình

Danh sách các bài nằm trong file `TODO.md`

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


***Mấy câu hỏi vớ vẩn kiểu như cài đặt như nào, làm thế nào để tải code về, etc... hay các câu hỏi liên quan đến lỗi syntax sẽ không được trả lời (kiểu như lỗi vì thiếu dấu ';', không đọc xong rồi hỏi sửa kiểu gì là cho next hết). Mấy cái này chịu khó đọc với tìm trên mạng là ra.***

# Nội dung thi giữa kì
- Bài toán n chữ số PI
- Bài toán cái túi (tham lam)
