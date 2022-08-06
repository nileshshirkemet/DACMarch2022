<%@ taglib prefix="my" uri="http://java.met.edu/basic/web/app" %>
<html>
	<head>
		<title>SimpleWebApp</title>
	</head>
	<body>
		<h1 style="">Welcome Visitor</h1>
		<b>Currrent Time: </b><my:clock format="dd/MM/yyyy hh:mm:ss a"/>
		<p>
			<b>WINNER: </b>
			<my:lotto digitVar="d" digitCount="8">
				<i>${d}</i>
			</my:lotto>
		</p>
	</body>
</html>

