using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFileManager.Model {
	public class Book : INotifyPropertyChanged{
		protected string _name;
		protected int _id;
		protected List<string> _tags;
		protected string _author;
		protected int _countWord;
		protected string _description;
		protected string _otherDescription;
		protected string _path;

		public Book() { }

		public string Name {
			get => _name;
			set {
				_name = value;
				OnPropertyChanged("Name");
			}
		}

		public int Id {
			get => _id;
			set {
				_id = value;
				OnPropertyChanged("Id");
			}
		}

		public string Tags {
			get {
				string tags = "";

				foreach (var tag in tags) {
					tags += tag + " ";
				}

				return tags;
			}
			set {
				_tags.Clear();

				foreach (var tag in value.Split('#')) {
					_tags.Add("#" + tag);
				}

				OnPropertyChanged("Tags");
			}
		}

		public string Author {
			get => _author;
			set {
				_author = value;
				OnPropertyChanged("Author");
			}
		}
		
		public int CountWord {
			get => _countWord;
			set {
				_countWord = value;
				OnPropertyChanged("CountWord");
			}
		}

		public string Description {
			get => _description;
			set {
				_description = value;
				OnPropertyChanged("Description");
			}
		}

		public string OtherDescription {
			get => _otherDescription;
			set {
				_otherDescription = value;
				OnPropertyChanged("OtherDescription");
			}
		}

		public string Path {
			get => _path;
			set {
				_path = value;
				OnPropertyChanged("Path");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public void OnPropertyChanged(string prop = "") {
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
		}
	}
}