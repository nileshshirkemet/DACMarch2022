<jsp:useBean id="now" class="java.util.Date"/>
<html>
	<head>
		<title>SimpleWebApp</title>
	</head>
	<body>
		<h1>Welcome ${empty param.user ? 'Visitor' : param.user}</h1>
		<b>Currrent Time: </b>${now}
	</body>
</html>

