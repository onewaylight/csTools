      //Typeface typeface = new Typeface("Times New Roman");
      Typeface typeface = new Typeface("나눔고딕폰트");
      double em_size = 40;

      string strText = "FormattedText";
      FrameworkElement grdMain = this.Content as FrameworkElement;

      FormattedText formatted_text = new FormattedText(
              strText, CultureInfo.CurrentUICulture,
              FlowDirection.LeftToRight,
              typeface, em_size, Brushes.Red, VisualTreeHelper.GetDpi(this).PixelsPerDip);

      // Center the text horizontally.
      //formatted_text.TextAlignment = TextAlignment.Center;

      // Find the center of the client area.
      double xmid = grdMain.ActualWidth / 2;
      double ymid = grdMain.ActualHeight / 2;
      Point center =
          new Point(xmid, ymid - formatted_text.Height / 2);

      Rectangle rc = new Rectangle();

      rc.Width = 300;
      rc.Height = 100;
      rc.Fill = Brushes.Blue;

      xmid = this.Width / 2;
      ymid = this.Height / 2;

      xmid = xmid - (rc.Width / 2);
      ymid = ymid - (rc.Height / 2);

      Canvas.SetLeft(rc, xmid);
      Canvas.SetTop(rc, ymid);


      myCanvas.Children.Add(rc);


      xmid = this.Width / 2;
      xmid = xmid - (formatted_text.Width / 2);

      ymid = this.Height / 2;
      ymid = ymid - (formatted_text.Height / 2);

      TextBlock textBlock = new TextBlock();
      textBlock.Text = "FormattedText";
      textBlock.Foreground = Brushes.Red;
      textBlock.FontSize = 40;
      Canvas.SetLeft(textBlock, xmid);
      Canvas.SetTop(textBlock, ymid);
      myCanvas.Children.Add(textBlock);
