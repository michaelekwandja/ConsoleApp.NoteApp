using ConsoleApp.NoteApp;

namespace NoteAppTest
{
    [TestClass]
    public class NoteTest
    {
        [TestMethod]
        public void Get_UserChoice_AndReturn()
        {
            // Arrange
            string note1 = "one";
            string note2 = "two";
            string note3 = "three";
            MenuResults.notes.Add(note1);
            MenuResults.notes.Add(note2);
            MenuResults.notes.Add(note3);
            int noteCount = 3;
            int index = 2;

            // Act
            MenuResults.DeleteNote(index);

            // Asserts
            Assert.IsFalse(noteCount == MenuResults.notes.Count);
        }

    }
}

