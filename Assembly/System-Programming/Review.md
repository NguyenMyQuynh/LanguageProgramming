# REVIEW 
<br></br>



![image](https://user-images.githubusercontent.com/62018010/129451688-7c9d7cdc-ba40-4c27-8f12-c025b57e9efd.png)

![image](https://user-images.githubusercontent.com/62018010/129451829-4a7e0345-32ee-46b0-8b07-dd6efc23069a.png)

![image](https://user-images.githubusercontent.com/62018010/129451874-8f9e3d64-9450-41b5-8028-f7b40dbecbd9.png)

![image](https://user-images.githubusercontent.com/62018010/129451513-86e07336-0656-4b86-bc68-e3ab8e76761c.png)

![image](https://user-images.githubusercontent.com/62018010/129452218-2b6bf64b-9178-4bcb-bcce-bfb6258c9d20.png)

<br>
</br>

#

![image](https://user-images.githubusercontent.com/62018010/129455434-b0463e26-3316-40ba-9c23-4268df48a6da.png)


<br>
</br>

#

> Phép dịch trái n bit tương đương với phép nhân với 2^n
<br> Phép chia không dấu cho 2^n bằng shift phải -  Sử dụng shift luận lý (logic shift) 

![image](https://user-images.githubusercontent.com/62018010/129448009-241d629f-3700-4f5e-9fa2-9032771df76f.png)

![image](https://user-images.githubusercontent.com/62018010/129455200-ed6f82da-3279-462b-b172-8ca2c1e03960.png)

![image](https://user-images.githubusercontent.com/62018010/129452702-323f9f57-6108-4465-9265-0ce615837e84.png)

![image](https://user-images.githubusercontent.com/62018010/129452731-a042dbef-6d2c-4ef4-a475-ac4a79db9d4b.png)

![image](https://user-images.githubusercontent.com/62018010/129452764-19523fa2-d1a2-444b-974a-3e1e7d403470.png)


<br>
</br>

#

![image](https://user-images.githubusercontent.com/62018010/129452973-faa7a15d-592c-4e89-a0ce-a8ecdf3d0adb.png)

![image](https://user-images.githubusercontent.com/62018010/129452807-ea474395-7684-4f6e-9eab-d5091b7217e8.png)

![image](https://user-images.githubusercontent.com/62018010/129453457-1ae6ea47-9436-40ee-86c1-056a7068985d.png)

![image](https://user-images.githubusercontent.com/62018010/129454310-8cc3cc3e-f797-4ade-a78c-0a986680e05a.png)

![image](https://user-images.githubusercontent.com/62018010/129454800-dad25699-f882-47a3-9e33-6a8000191b3a.png)

![image](https://user-images.githubusercontent.com/62018010/129454852-47585a61-2972-45f7-9cbf-b4159bd57643.png)

<br>
</br>

#

![image](https://user-images.githubusercontent.com/62018010/129455384-4c516893-96d6-4fc5-abbb-f3a1cec83eb2.png)

![image](https://user-images.githubusercontent.com/62018010/129455397-98810ef6-2a7a-4315-a38a-10b68b33d251.png)
![image](https://user-images.githubusercontent.com/62018010/129455463-e85f4437-881c-4f54-b5dd-b9335dcf71d3.png)
![image](https://user-images.githubusercontent.com/62018010/129455539-644d2650-0e77-429d-8c55-4419e924ae3b.png)

![image](https://user-images.githubusercontent.com/62018010/129456139-6599fe1c-905e-4934-9f40-8603820fc98a.png)
![image](https://user-images.githubusercontent.com/62018010/129456146-ee0dc09e-5877-4c0d-a4b0-d6c08b8317d3.png)

![image](https://user-images.githubusercontent.com/62018010/129456301-25928cb9-77de-448d-a107-988ba5eab9b4.png)


<br>
</br>

#

![image](https://user-images.githubusercontent.com/62018010/129464139-5157ae2e-8694-492a-b6a9-a23717b73ce8.png)

![image](https://user-images.githubusercontent.com/62018010/129464346-9103aa51-39de-4ff7-bc69-e5d127afc32d.png)



> - Compiler: Biên dịch từ mã C thành mã assembly với lệnh: `gcc –S test.c`
> - Assembler: 
>   - Chuyển từ file.s sang .o
>   - Biểu diễn nhị phân của mỗi instruction 
>   - Thiếu phần liên kết giữa mã code trong nhiều files 
> - Linker 
>   - Giải quyết các tham chiếu giữa các file 
>   - Liên kết với các thư viện tĩnh, vd: code của các hàm malloc, printf 
>   - Một số thư viện được liên kết động - Liên kết được thực hiện khi chương trình bắt đầu chạy

<br> 

![image](https://user-images.githubusercontent.com/62018010/129464615-575a814d-b5a6-4b9e-8c9f-9a04ab9285f0.png)
![image](https://user-images.githubusercontent.com/62018010/129464643-58f561bb-761f-4555-b71a-3108423c5313.png)

> - Disassembling Object Code:  
>   - Objdump: `objdump –d <tên file> `
>     Hoặc gdb Debugger: `gdb <tên file>`  `disassemble <tên hàm>`
>     - Phân tích các chuỗi bit của chuỗi các instructions 
>     - Tạo ra mã assembly gần đúng 
>     - Có thể chạy trên cả file a.out (file thực thi đầy đủ) hoặc .o



<br>
</br>

#
![image](https://user-images.githubusercontent.com/62018010/129467777-47f32d44-b8d2-44f4-a8e8-53c04aefff18.png)

<br>
</br>

#

![image](https://user-images.githubusercontent.com/62018010/129465148-5a09070c-581c-4136-947e-815111cb2ee7.png)

![image](https://user-images.githubusercontent.com/62018010/129465244-6436235e-b3ca-4b5b-9a7a-2d3b10d53354.png)

![image](https://user-images.githubusercontent.com/62018010/129467943-65ebbed8-bffc-4ff7-9e56-76fc184ed00c.png)
![image](https://user-images.githubusercontent.com/62018010/129467948-f4162784-2cf3-4414-bff0-68866b058000.png)

![image](https://user-images.githubusercontent.com/62018010/129477313-762f0e15-103d-4e3b-a39d-7a02cbcd8e21.png)

![image](https://user-images.githubusercontent.com/62018010/129477324-21072d12-443c-49ea-860a-c3d38378ea77.png)
![image](https://user-images.githubusercontent.com/62018010/129477351-919e6bbf-e378-45f1-b876-647721a75d47.png)
![image](https://user-images.githubusercontent.com/62018010/129477580-f131d065-4532-481f-bede-2ef9e551ac84.png)
![image](https://user-images.githubusercontent.com/62018010/129477665-94cfe384-7c86-4a98-a470-d3f9da281e52.png)

<br>

> `Jump Table` là mảng địa chỉ của các block code ứng với các trường hợp của switch

![image](https://user-images.githubusercontent.com/62018010/129486499-15d98ab6-edc7-465c-8479-bf0d527aee8b.png)

![image](https://user-images.githubusercontent.com/62018010/129504391-9450a678-1813-468a-b28e-4330ddc25fd9.png)
![image](https://user-images.githubusercontent.com/62018010/129504412-354b8616-0c6b-4d07-85aa-5ca086f3967c.png)


<br>
</br>

#

![image](https://user-images.githubusercontent.com/62018010/129486527-5f0e3786-ba87-444d-bc7a-f5edc09cff07.png)
![image](https://user-images.githubusercontent.com/62018010/129486710-fceaaa95-d995-48e7-9afb-87274a0e5a8f.png)

> Nếu sửa `zip_dig` thành `short[5]`, Dòng code 3 sẽ sửa thành: `movw (%edx, %eax, 2), %eax`

![image](https://user-images.githubusercontent.com/62018010/129486725-fe59fc67-b27e-4b2e-b19f-67cee2f36154.png)

> - Địa chỉ phần tử i mảng 1 chiều A: `A + i*4`
> - Địa chỉ dòng i mảng 2 chiều A: `A + (i*C*K)`
> - Địa chỉ phần tử A[i][j]: `A + (i*C*K) +(j*K)`

![image](https://user-images.githubusercontent.com/62018010/130315159-4660c13b-87b4-476b-8277-1735333e4329.png)



<br>
</br>

#
> - Quy tắc căn chỉnh:
>   - Địa chỉ lưu dữ liệu kiểu nào thì phải chia hết cho kichs thước kiểu dữ liệu đó.
>   - Struct:
>     - Yêu cầu căn chỉnh riêng lớn nhất sẽ là yêu cầu căn chỉnh chung.
>     - Địa chỉ đầu tiên phải chia hết cho yêu cầu căn chỉnh chung.
>     - Tổng kích thước struct phải chia hết cho yêu cầu căn chỉnh chung.

![image](https://user-images.githubusercontent.com/62018010/130315627-f63eb82d-f318-4e92-838d-36642a6cd46c.png)


<br>
</br>

#
![image](https://user-images.githubusercontent.com/62018010/130314644-de7ae805-b82c-44a8-9a01-27bb8344c2d2.png)

> - Tham số đầu tiên đưa vào vị trí gần đỉnh stack nhất (esp, esp +4, ...)
> - Khi call hàm tham số đầu tiên epb+8.

![image](https://user-images.githubusercontent.com/62018010/130314665-90f963ab-724c-4c5d-b798-e2cc5b72908e.png)


![image](https://user-images.githubusercontent.com/62018010/130314682-a8f23376-e241-4404-903e-c12c30b74ad2.png)
![image](https://user-images.githubusercontent.com/62018010/130314750-7f50ec01-0760-4207-916d-0f97abbf7690.png)


![image](https://user-images.githubusercontent.com/62018010/130314755-47bb3498-db0b-4ef2-8536-1400df354f18.png)

![image](https://user-images.githubusercontent.com/62018010/130314765-e0b4f081-58ed-464b-ae59-91bfa0cc6f63.png)
![image](https://user-images.githubusercontent.com/62018010/130314773-f8a435d7-b2ae-4a14-8538-a194b71fb02c.png)
![image](https://user-images.githubusercontent.com/62018010/130314807-6ca0c486-a436-4551-872a-59b0391fdf12.png)


![image](https://user-images.githubusercontent.com/62018010/130314824-0b42c871-e66b-4bf0-a922-a65d16fc8eeb.png)



<br>
</br>

#

![image](https://user-images.githubusercontent.com/62018010/129489218-69bbe569-258d-4922-8072-8d2a1b49c442.png)

![image](https://user-images.githubusercontent.com/62018010/129507322-b824ed17-295c-4314-b128-8596d065bde0.png)

![image](https://user-images.githubusercontent.com/62018010/129507367-135f49e0-d099-4500-a144-82abc6e82877.png)


<br>
</br>

#
![image](https://user-images.githubusercontent.com/62018010/130314139-1d64a9bf-6ca4-499a-80a1-04161b1b2482.png)

![image](https://user-images.githubusercontent.com/62018010/130314164-4b36b110-dccd-4798-a061-9099df1310af.png)
![image](https://user-images.githubusercontent.com/62018010/130314171-7c5f8a26-c9e9-413e-a039-1fb5127667b0.png)

> Hàm và biến toàn cục sẽ có trong symbol table. 

![image](https://user-images.githubusercontent.com/62018010/130314225-d5dc0a55-39c4-4d20-b5f5-d1d1183ab3d1.png)
![image](https://user-images.githubusercontent.com/62018010/130314228-177de5cc-2f23-44e2-a418-30ceec5bbe0d.png)

![image](https://user-images.githubusercontent.com/62018010/130314249-dbfd990b-c96c-4aaa-8b89-32b33758354e.png)


![image](https://user-images.githubusercontent.com/62018010/130314316-4d2f2233-e6b0-4e42-908b-b3aeee7e3bd8.png)
![image](https://user-images.githubusercontent.com/62018010/129508154-d1899a83-37f4-4a82-b764-551105acb0e9.png)
![image](https://user-images.githubusercontent.com/62018010/130314332-55ec846e-23ed-47b0-9f39-6866b87375a1.png)

> Linker’s Symbol Rules
> - Strong symbol chỉ đc khai báo ở một nơi duy nhất.
> - 2 weak symbol cùng tên thì chọn bất kì, 2 weak symbol khác kiểu dữ liệu có thể overwrite.
> - 1 strong symbol với nhiều weak symbol cùng tên thì không lỗi và sẽ lấy strong symbol.

![image](https://user-images.githubusercontent.com/62018010/130314430-9cdd52fa-dee2-4f16-9aac-56f8508b98db.png)









