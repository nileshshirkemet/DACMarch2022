package basic.web.app;

import java.io.*;
import java.util.*;
import java.text.*;
import jakarta.servlet.jsp.*;
import jakarta.servlet.jsp.tagext.*;

public class ClockTag implements SimpleTag {

	private JspContext context;
	private JspFragment body;
	private JspTag parent;
	private SimpleDateFormat formatter = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss");

	public void setJspContext(JspContext value) { context = value; }

	public void setJspBody(JspFragment value) { body = value; }

	public void setParent(JspTag value) { parent = value; }

	public JspTag getParent() { return parent; }

	public void setFormat(String value) { 
		formatter.applyPattern(value);
	}

	public void doTag() throws IOException, JspException {
		var out = context.getOut();
		var now = new Date();
		out.print(formatter.format(now));
	}
}

