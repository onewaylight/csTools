
  DateTime nowDt = DateTime.Now;

  if (nowDt.DayOfWeek == DayOfWeek.Monday)
      return "월";
  else if (nowDt.DayOfWeek == DayOfWeek.Tuesday)
      return "화";
  else if (nowDt.DayOfWeek == DayOfWeek.Wednesday)
      return "수";
  else if (nowDt.DayOfWeek == DayOfWeek.Thursday)
      return "목";
  else if (nowDt.DayOfWeek == DayOfWeek.Friday)
      return "금";
  else if (nowDt.DayOfWeek == DayOfWeek.Saturday)
      return "토";
  else if (nowDt.DayOfWeek == DayOfWeek.Sunday)
      return "일";
  else
      return "";
