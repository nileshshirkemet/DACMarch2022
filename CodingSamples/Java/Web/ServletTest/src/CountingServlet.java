package simple.web.app;

import java.io.*;
import jakarta.servlet.*;
import jakarta.servlet.http.*;
import jakarta.servlet.annotation.*;

@WebServlet("/count")
public class CountingServlet extends HttpServlet {

	//private int count = 0;

	@Override
	public void doPost(HttpServletRequest request, HttpServletResponse response) throws IOException, ServletException {
		String guest = request.getParameter("user");
		if(guest.length() == 0){
			response.sendRedirect("welcome");
			return;
		}
		var session = request.getSession(true);
		Integer count = (Integer)session.getAttribute(guest);
		if(count == null)
			count = 0;
		response.setContentType("text/html");
		var out = response.getWriter();
		out.println("<html>");
		out.println("<head><title>SimpleWebApp</title></head>");
		out.println("<body>");
		out.printf("<h1>Hello %s</h1>%n", guest);
		out.printf("<b>Number of Greetings: </b>%d%n", ++count);
		out.println("</body>");
		out.println("</html>");
		out.close();
		session.setAttribute(guest, count);
		if(count > 5)
			session.invalidate();
	}
}

