<jsp:useBean id="counter" class="basic.web.app.CounterBean" scope="application"/>
<jsp:useBean id="greeter" class="basic.web.app.GreeterBean"/>
<jsp:setProperty name="greeter" property="*"/>
<html>
	<head>
		<title>SimpleWebApp</title>
	</head>
	<body>
		<h1>${greeter.message}</h1>
		<p>
			<b>Number of Greetings: </b>${counter.nextCount}
		</p>
		<form method="post">
			<p>
				<b>Person</b><br/>
				<input type="text" name="person"/>
			</p>
			<p>
				<b>Interval</b><br/>
				<select name="interval">
					<option>Night</option>
					<option>Morning</option>
					<option>Afternoon</option>
					<option>Evening</option>
				</select>
			</p>
			<input type="submit" value="Greet"/>
		</form>
	</body>
</html>

