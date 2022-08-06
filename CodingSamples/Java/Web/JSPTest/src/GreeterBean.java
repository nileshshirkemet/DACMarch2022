package basic.web.app;

public class GreeterBean implements java.io.Serializable {

	private String person;
	private String interval;

	public final String getPerson() { return person; }
	public final void setPerson(String value) { person = value; }

	public final String getInterval() { return interval; }
	public final void setInterval(String value) { interval = value; }

	public String getMessage() {
		if(person == null)
			return "Welcome Visitor";
		return String.format("Good %s %s", interval, person);
	}
}

