package simple.web.app;

import java.io.*;
import java.util.*;
import jakarta.servlet.*;

public class GreetingServlet implements Servlet {

	private ServletConfig config;

	public void init(ServletConfig cfg) throws ServletException {
		config = cfg;
	}

	public ServletConfig getServletConfig() {
		return config;
	}

	public String getServletInfo() {
		return "Greeting Servlet";
	}

	public void service(ServletRequest request, ServletResponse response) throws IOException, ServletException {
		String guest = request.getParameter("user");
		if(guest == null)
			guest = "Visitor";
		response.setContentType("text/html");
		var out = response.getWriter();
		out.println("<html>");
		out.println("<head><title>SimpleWebApp</title></head>");
		out.println("<body>");
		out.printf("<h1>Welcome %s</h1>%n", guest);
		out.printf("<b>Current Time: </b>%s%n", new Date());
		out.println("</body>");
		out.println("</html>");
		out.close();
	}

	public void destroy() {}
}

