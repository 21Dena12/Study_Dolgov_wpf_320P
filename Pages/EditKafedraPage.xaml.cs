using Study_Kamalov_wpf_320P.Connection;
using Study_Kamalov_wpf_320P.DbModel;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Controls;
using System.Windows;
using System;


namespace Study_Kamalov_wpf_320P.Pages
{
    public partial class EditKafedraPage : Page
    {
        private Kafedra _currentKafedra;

        public EditKafedraPage(Kafedra kafedra)
        {
            InitializeComponent();
            _currentKafedra = kafedra;
            LoadFaculties();
            LoadKafedraData();
        }

        private void LoadFaculties()
        {
            var faculties = ConnectionHelper.db.Fackultet
                .OrderBy(f => f.Name_fackul)
                .ToList();
            FacultyComboBox.ItemsSource = faculties;
        }

        private void LoadKafedraData()
        {
            ShifrBox.Text = _currentKafedra.Shifr;
            NameBox.Text = _currentKafedra.Name_kaf;

            if (!string.IsNullOrEmpty(_currentKafedra.Facultet))
            {
                var faculty = ConnectionHelper.db.Fackultet.FirstOrDefault(f => f.Abbriveatura_fackul == _currentKafedra.Facultet);
                FacultyComboBox.SelectedItem = faculty;
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Проверка обязательных полей
                if (string.IsNullOrWhiteSpace(ShifrBox.Text) ||
                    string.IsNullOrWhiteSpace(NameBox.Text) ||
                    FacultyComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Пожалуйста, заполните все обязательные поля");
                    return;
                }

                // Обновление данных кафедры
                _currentKafedra.Shifr = ShifrBox.Text.Trim();
                _currentKafedra.Name_kaf = NameBox.Text.Trim();
                _currentKafedra.Facultet = (FacultyComboBox.SelectedItem as Fackultet)?.Abbriveatura_fackul;

                // Сохранение изменений в базе данных
                ConnectionHelper.db.SaveChanges();

                MessageBox.Show("Кафедра успешно обновлена");
                NavigationService.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}");
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}