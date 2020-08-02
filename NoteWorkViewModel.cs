using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVVM
{
    class NoteWorkViewModel : INotifyPropertyChanged
    {
        private NoteWork _selectedNote;
        public ObservableCollection<NoteWork> Notes
        {
            get;
            set;
        }

        public NoteWork SelectedNote
        {
            get
            {
                return _selectedNote;
            }
            set
            {
                _selectedNote = value;
                OnPropertyChanged("SelectedNote");
            }
        }

        public NoteWorkViewModel()
        {
            Notes = new ObservableCollection<NoteWork>
            {
                new NoteWork
                {
                    Title ="Хенерал Сасисов",
                    TextNote ="Чемпион сектора Аврелия.",
                    DataStart ="2020-11-2",
                    DataEnd="2020-12-18",
                    IsDone=false,
                    ColorID=13
                },
                new NoteWork
                {
                    Title ="Гапитан Колбасов",
                    TextNote ="Затащил на арене против гретчина.",
                    DataStart ="3934-9-28",
                    DataEnd="3939-2-14",
                    IsDone=false,
                    ColorID=17
                },
                new NoteWork
                {
                    Title ="Натюре Прохет",
                    TextNote ="Интернетный эксперт с двухлетнем стажем и тремя золотыми кнопками.",
                    DataStart ="7531-12-5",
                    DataEnd="8932-1-2",
                    IsDone=true,
                    ColorID=24
                }
            };
        }

        public void AddNote()
        {
            NoteWork Note = new NoteWork();
            Notes.Insert(0, Note);
            SelectedNote = Note;
        }

        public void DeleteNote()
        {
            if (_selectedNote != null)
            {
                Notes.Remove(SelectedNote);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}