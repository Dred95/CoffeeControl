<?php
 
/*���������� � ����� � ������ ������� �� �������*/
header('Content-type: text/html; charset=utf8');
$connect_to_db =mysql_connect("coffee-control.ru", "u0187820_default", "280595");

mysql_query('SET names "utf8"');
mysql_select_db("u0187820_default");

//������ ���������
$sql_worker = "SELECT name FROM workers"; 
$result_select_worker = mysql_query($sql_worker);
//������ ������
$sql_shop = "SELECT title FROM shops"; 
$result_select_shop = mysql_query($sql_shop);
//���� ����
$dateUP = isset($_POST['dateUP']) ? $_POST['dateUP'] : 'Unknown';
$dateEND = isset($_POST['dateEND']) ? $_POST['dateEND'] : 'Unknown';




 
?>
<html>
<head>
<meta http-equiv=�Content-Type� content=�text/html; charset="utf8" >
</head>
<body>



<select size="1" name='shop'>
       <?php header('Content-type: text/html; charset=utf8');
        while($object = mysql_fetch_object($result_select_shop)): ?>
    <option value ="<?=$object->{title}?>"><?=$object->{title}?></option>
    <?php endwhile;?>
   </select>



   <select size="1" name='worker'>
       <?php header('Content-type: text/html; charset=utf8');
        while($object = mysql_fetch_object($result_select_worker)): ?>
    <option value ="<?=$object->{name}?>"><?=$object->{name}?></option>
    <?php endwhile;?>
   </select>


<form action="lost.php" method="post" accept-charset="utf8">
DateUP ( year-month-day: 2016-05-04): <input type=text name="dateUP"><br>
DateEND ( year-month-day: 2016-05-04): <input type=text name="dateEnd"><br>
<input type=submit value="GO!">
</form>


   
  
</body>
</html>
<?php mysql_close($connect_to_db);
?>

