# Calculator

by Panuwat Prasertdee,
673450474-0,
Computer and Infomation Science, KKU

# การรับและการแสดงผลข้อมูล

รับข้อมูลจากผู้ใช้งาน และทำงานผ่านการกดปุ่มเพื่อคำนวนตัวเลข

## ปุ่มบวก

```
 private void button1_Click(object sender, EventArgs e)
 {
     // ข้อความตัวอักษร
     string inputNum1 = num1.Text;
     string inputNum2 = num2.Text;
     // convert str to double 
     double iNum1 = Double.Parse(inputNum1);
     double iNum2 = Double.Parse(inputNum2);
     // int ทำให้สามารถ + - * / ได้
     // double เเละ flout ทศนิยม
     double iResult = iNum1 + iNum2; // function + - * /
     // ที่ตัวเเปรชื่อ  Result
     // มีคุณสมบัติชื่อ text
     // ใส่ข้อความคำว่า Hello World
     Result.Text = iResult.ToString();  // .ToString() เเปลงกับเป็น str
 }
```

### รับข้อมูล

ตัวอย่าง

```
string inputNum1 = num1.Text;
string inputNum2 = num2.Text;
```

### แปลงชนิดของข้อมูล

ตัวอย่าง

```
double iNum1 = Double.Parse(inputNum1);
double iNum2 = Double.Parse(inputNum2);

```

### คำนวนผลลัพท์

```
double iResult = iNum1 + iNum2; // function + - * /
```

### แสดงผล

ตัวอย่าง

```
Result.Text = iResult.ToString(); // .ToString() เเปลงกับเป็น str
```

## ปุ่มลบ
```
string inputNum1 = num1.Text;
string inputNum2 = num2.Text;
// convert str to double
double iNum1 = Double.Parse(inputNum1);
double iNum2 = Double.Parse(inputNum2);
double iResult = iNum1 - iNum2; 
Result.Text = iResult.ToString();
```
## ปุ่มคูณ
```
string inputNum1 = num1.Text;
string inputNum2 = num2.Text;
// convert str to double
double iNum1 = Double.Parse(inputNum1);
double iNum2 = Double.Parse(inputNum2);
double iResult = iNum1 * iNum2; 
Result.Text = iResult.ToString();str
```
## ปุ่มหาร
```
string inputNum1 = num1.Text;
string inputNum2 = num2.Text;
// convert str to double
double iNum1 = Double.Parse(inputNum1);
double iNum2 = Double.Parse(inputNum2);
double iResult = iNum1 / iNum2; 
Result.Text = iResult.ToString();
```
## ปุ่มลบข้อมูล
```  
  private void button5_Click(object sender, EventArgs e)
  {
      // ล้างข้อความใน TextBox
      num1.Text = "";
      num2.Text = "";
      Result.Text = ""; 
  }
```