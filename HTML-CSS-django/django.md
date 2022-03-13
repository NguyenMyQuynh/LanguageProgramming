# Django

<br>

## How to Change the port on VS Code Live Server?
  - Step 1. Open up VS Code.
  - Step 2. Use Ctrl+Shift+I Shortcut key to open up Extensions (on the left side).
  - Step 3. Find out the live server extension, then click on the gear icon at the bottom of it, and open up Extension Settings.
  - Step 4. Here, find out, `Live Server > Settings: Port` (both in user and workspace), under this, click on `Edit in settings.json`.

      ![image](https://user-images.githubusercontent.com/62002485/140641361-e8fb04e7-1b3a-487b-a95a-b84f02ebd12b.png)
      
      ![image](https://user-images.githubusercontent.com/62002485/140647290-9b63534e-3e6c-4bdf-8f7b-9e39f37ce5c2.png)
    
  - Step 5. Here, set the port on which you wanna open up live server (set value to 0 for random ports).
  
      ![image](https://user-images.githubusercontent.com/62002485/140645954-208cc093-fbca-4204-9f87-d4fdc0cceba3.png)
    
      ![image](https://user-images.githubusercontent.com/62002485/140647369-05a78b13-28c2-4b48-b7fa-a2b660a9874a.png)
        
  - Access server:
  
    - Win: press GoLive or url.
    - Linux: Access url `localhost:8000` (8000 can replace by port which set in 2 file setting) 

<i>**Command runserver with specific port: `python .\manage.py runserver 8080` (8080 can replace by the other port) <br> Note: cd into correct folder which include manage.py to runserver.</i>

By these steps, you can change the port on VS Code Live Server.

<br>

## How to check which packages are installed in system python or virtual environment python:

In the python console is to call help() the inbuilt function. This will not provide documentation for modules that are not installed, for example:

   ![image](https://user-images.githubusercontent.com/62002485/141666959-d175831e-a83a-46fe-8daf-2f457936378b.png)

   ![image](https://user-images.githubusercontent.com/62002485/141666967-ea8626dd-7d1b-4961-b3c2-c8db7257ef6d.png)
   
   ![image](https://user-images.githubusercontent.com/62002485/141671249-4311e7eb-ec52-49f1-9ca4-63993789a29b.png)
   
<br>

## Python interpreter in VSCode: 

   ![image](https://user-images.githubusercontent.com/62002485/141682278-57d74b71-bd97-4d32-b468-503f210990d1.png)
   
   ![image](https://user-images.githubusercontent.com/62002485/141682355-0191de67-cb9c-4829-b79f-7124df7c71c2.png)

<br>

## Manipulating with Django project:

- Cài python:
<br> https://quantrimang.com/cach-cai-dat-python-tren-windows-macos-linux-140625

- Tìm đường dẫn cài python và thêm nó vào biến môi trường:
  - https://quantrimang.com/them-python-vao-bien-windows-path-175930
  - Tìm đường dẫn (cách 2):
    ``` 
    >>> import os
    >>> import sys
    >>> os.path.dirname(sys.executable)
    'C:\\Program Files (x86)\\Microsoft Visual Studio\\Shared\\Python37_64'
    >>> 
    ```
  
   - Một số đường dẫn python thường gặp:

      ![image](https://user-images.githubusercontent.com/62002485/137639071-ec037e33-53f3-4c5b-a092-084471b03fe3.png)

      ![image](https://user-images.githubusercontent.com/62002485/137640070-1b074b43-dc72-436c-b013-fdf62ff9070f.png)
      
   - My python folder path: 
      <br> ![image](https://user-images.githubusercontent.com/62002485/141671122-55273787-96d0-4352-bad0-b444acd655ab.png)

- Check python: 

   ![image](https://user-images.githubusercontent.com/62002485/137640477-1219fb82-250f-4405-8d88-b527fc60a904.png)
   
- Mở terminal lên tạo thư mục làm việc và di chuyển vào.
<br>

## Linux

- Tạo môi trường ảo:

  ![image](https://user-images.githubusercontent.com/62002485/140637152-5477a00b-118c-44c5-a9bf-69d37d36d9fb.png)

- Kích hoạt môi trường ảo: (các lần sau chỉ cần cd vào thư mục chứa thư mục môi trường ảo và source vào môi trường ảo đã tạo)

  ![image](https://user-images.githubusercontent.com/62002485/140637155-cbd6d03a-5c5f-42b6-8c2b-82f65e918c29.png)

- Mở với VSCode:

  ![image](https://user-images.githubusercontent.com/62002485/140637160-f4720f98-67e5-4606-b67c-cabe9dbe53c8.png)

  ![image](https://user-images.githubusercontent.com/62002485/140637194-4ac18ce8-237b-4ef0-a9a1-266eaf91cdd0.png)

  ![image](https://user-images.githubusercontent.com/62002485/140637373-994b14c6-922c-4e06-8be9-098af487fbd9.png)


<br>

- Cài đặt pip để cài các package:

  - `python -m ensurepip --upgrade`

<br>

- Cài  
  - `pip install -U pip wheel`

<br>

- Cài django và kiểm tra:
  - `pip install django`
  - `django-admin`

<br>

- Tạo project:
  - `django-admin startproject project-name`

<br>

## Win


- Tạo môi trường ảo và kích hoạt:

   ![image](https://user-images.githubusercontent.com/62002485/141666408-e5107f4d-071c-43e4-b350-01dc8e226d96.png)


- Cài đặt pip để cài các package:

  - `python -m ensurepip --upgrade`
  - Cài: `python -m pip install -U pip wheel`

  ![image](https://user-images.githubusercontent.com/62002485/140647679-1fd79aa9-8765-4d3b-a9dc-307855e66c16.png)
    
<br>

- Cài django và kiểm tra:
  - `pip install django`
  - `django-admin`

<br>

- Tạo project:
  - `django-admin startproject project-name`

<br>

<br>

- Sau này muốn phát triển tiếp project đó, ta làm như sau (project đó nên tạo app và đã runserver ít nhất 1 lần rồi):

  - Linux: 

    ![1](https://user-images.githubusercontent.com/62002485/138463615-0bc02830-002f-47aa-9fc5-be046aa9e58f.png)

    ![2](https://user-images.githubusercontent.com/62002485/138463719-9e01dfe1-bf79-4668-8ca3-c6f6a49dc123.png)
    
  - Win:

      ![image](https://user-images.githubusercontent.com/62002485/140648613-28c01643-a5f0-4838-9685-bd612d58916d.png)

      ![image](https://user-images.githubusercontent.com/62002485/140648644-2f985770-f9c6-44bf-954e-c9a959ef5606.png)


- Video tham khảo: https://youtu.be/9HWgWFYeH1Q
- Code with Harry: https://www.codewithharry.com/videos/python-django-tutorials-hindi-88


<br>

#

- Tạo 1 Web App: 
  <br> `python manage.py startapp <Tên APP>`

- Ta vào mục PythonWeb, mở file settings.py. Ở phần khai báo INSTALLED_APPS, ghi thêm tên App vào trong:
  ![3](https://user-images.githubusercontent.com/62002485/138507583-c993011e-756d-4df2-9a99-b50cec2e1c14.png)

- Để cập nhật cho phần settings:
<br> `python manage.py migrate`

- Thao tác với webapp: [Video](https://youtu.be/ngq12n9xfes)


<br>

# 

- Bây giờ ta vào file models.py trong app blog để thiết kế bảng Post:

  ![4](https://user-images.githubusercontent.com/62002485/138509720-cdb5a251-0b06-4c08-ab65-68fd7a5277e0.png)

```
class Post(models.Model):
    title = models.CharField(max_length=100)
    body = models.TextField()
    date = models.DateTimeField(auto_now_add=True)
```
- Tạo ra file migration cho Database ta đã thiết kế một model Post trong app blog:
<br> `python manage.py makemigrations blog`

  ![image](https://user-images.githubusercontent.com/62002485/141687990-6cf1b6cb-bfce-48f6-9c1a-2994b573906f.png)


-   Bắt django chạy các file migration này để nó thực hiện đến database:
<br> `python .\manage.py migrate`

    ![image](https://user-images.githubusercontent.com/62002485/141688000-a5c500bf-5c00-480e-9fd7-ac928fe52968.png)


- Dùng phần mềm DB Browser for SQLite để mở file db.sqlite3 trong project Django.


- Chi tiết hệ cơ sở quản trị dữ liệu trong file setting thư mục gốc:
  - ENGINE: tên hệ quản trị cơ sở dữ liệu.
  - NAME: Tên file database, BASE_DIR: đường dẫn thư mục dự án.
  
  ![image](https://user-images.githubusercontent.com/62002485/141688386-e0822cc9-c65e-4a68-a05e-0c9c4ec8e238.png)

- Cài package cần thiết cho PostgreSQL(nếu muốn chuyển hệ QTCSDL):
  
  - https://www.postgresql.org/download/linux/debian/

  - `pip install psycopg2`



<br>

#

- Tạo một tài khoản admin để truy cập vào hệ thống:
<br> `python manage.py createsuperuser`

- Bật server lên và vào đường dẫn /admin và dùng tài khoản vừa tạo để đăng nhập.

- Thêm vào file admin.py trong app để hiển thị bảng trên giao diện admin khi đăng nhập vào hệ thống: 
  ![image](https://user-images.githubusercontent.com/62002485/141690347-e347e3f2-c6af-4c03-8d65-362a1257d357.png)
  
  
<br>

#

- Trong file urls.py của project `include urls.py của app` vào để project có thể hiểu được các đường dẫn con của app đó, `tham số thứ nhất là đường dẫn tương đối` khi truy cập trên browser vào app đó.

  ![image](https://user-images.githubusercontent.com/62002485/141753565-fe0e02c1-45d5-420c-bb53-53a40c6caf97.png)
  
- Trong file urls.py của app `với mỗi đường dẫn con tương đối` (khi truy cập trên browser), gọi hàm tương ứng trong views.py của app(nhớ import views):

  ![image](https://user-images.githubusercontent.com/62002485/141753868-b84cc840-6c62-4c11-a3be-6b4573099a0c.png)
  
- Trong file views.py của app render tới file html dùng đường dẫn tương đối (vì templates của app ngang hàng với views.py nên có thể tự hiểu hoặc cài templates path trong setting.py của project nếu cần)

  ![image](https://user-images.githubusercontent.com/62002485/141754332-88780eb8-6624-489f-837f-cb1e40f2f720.png)
  
  ![image](https://user-images.githubusercontent.com/62002485/141755167-2b5c1c91-47b9-4301-ba49-bce032953115.png)
  
  
<br>

#

  ![image](https://user-images.githubusercontent.com/62002485/141777581-61905d4f-a7a8-4369-a7a2-0f2c1f85e988.png)
  
- Tạo class form tương ứng model:

  ![image](https://user-images.githubusercontent.com/62002485/141777868-e718b9fb-cb14-49ad-a397-64e154a1f255.png)

- Trong file urls.py của app add thêm đường dẫn con vào:

  ![image](https://user-images.githubusercontent.com/62002485/141776429-e3b7d2e7-39f4-4317-8cf1-10c8f9145a58.png)
  
- Trong views.py import form vào và truyền biến form cho html và render: 

  ![image](https://user-images.githubusercontent.com/62002485/141776701-9cafb5dc-bdc0-49f8-8f46-35cf21a4a2da.png)
  
  ![image](https://user-images.githubusercontent.com/62002485/141777909-5a8ea316-c8f5-4ff9-b614-ddff0654c8eb.png)










