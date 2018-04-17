C# MessageBox (ICON)圖示

Asterisk	
訊息方塊包含的符號是圓形中有一個小寫字母 i。

Error	
訊息方塊包含的符號是紅底圓形中有一個白色 X。

Exclamation	
訊息方塊包含的符號是黃底三角形中有一個驚嘆號。

Hand	
訊息方塊包含的符號是紅底圓形中有一個白色 X。

Information	
訊息方塊包含的符號是圓形中有一個小寫字母 i。

None	
訊息方塊沒有包含符號。

Question	
訊息方塊包含的符號是圓形中有一個問號。 我們不再建議使用問號的訊息圖示，因為它並未清楚表示特定類型的訊息，且問題訊息的措辭適用於各種訊息。 此外，使用者可能會將訊息符號的問號與「說明」資訊搞混。 因此，請勿在您的訊息方塊中使用這個問號訊息符號。 系統繼續支援將其納入，只為回溯相容性之用。

Stop	
訊息方塊包含的符號是紅底圓形中有一個白色 X。

Warning	
訊息方塊包含的符號是黃底三角形中有一個驚嘆號。


EX:
            MessageBox.Show("MessageBoxIcon.Asterisk", "MessageBox.Show", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            MessageBox.Show("MessageBoxIcon.Error", "MessageBox.Show", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show("MessageBoxIcon.Exclamation", "MessageBox.Show", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            MessageBox.Show("MessageBoxIcon.Hand", "MessageBox.Show", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            MessageBox.Show("MessageBoxIcon.Information", "MessageBox.Show", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("MessageBoxIcon.None", "MessageBox.Show", MessageBoxButtons.OK, MessageBoxIcon.None);
            MessageBox.Show("MessageBoxIcon.Question", "MessageBox.Show", MessageBoxButtons.OK, MessageBoxIcon.Question);
            MessageBox.Show("MessageBoxIcon.Stop", "MessageBox.Show", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            MessageBox.Show("MessageBoxIcon.Warning", "MessageBox.Show", MessageBoxButtons.OK, MessageBoxIcon.Warning);