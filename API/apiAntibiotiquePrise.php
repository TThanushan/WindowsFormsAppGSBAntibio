<?php
	// apiCategorie.php
	 $rows=null;
	 $connection = mysqli_connect("localhost", "root", "", "baseAntibio");
	 mysqli_query($connection,"SET CHARACTER SET 'utf8'");
	 mysqli_query($connection,"SET SESSION collation_connection ='utf8_unicode_ci'");
	 if(mysqli_connect_errno()) { die("Database connection failed " . "(" . mysqli_connect_error() . " - " . mysqli_connect_errno() . ")"); }
	 $query = "SELECT * from antibiotique where unite not like '%kg'";
	 $rep = mysqli_query($connection, $query);
	 if(mysqli_num_rows($rep) > 0){
	 $rows = mysqli_fetch_all($rep, MYSQLI_ASSOC);
	 }
	 echo json_encode($rows, JSON_UNESCAPED_UNICODE | JSON_UNESCAPED_SLASHES);
?>