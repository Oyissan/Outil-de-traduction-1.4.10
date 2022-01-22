Module Language
    Private _SelectedLanguage As String
    Public Property SelectedLanguage() As String
        Get
            Return _SelectedLanguage
        End Get
        Set(ByVal value As String)
            _SelectedLanguage = value
        End Set
    End Property

    Structure English
#Region "Fenêtre maître"
        Shared MS_MainMenu_BTN_HelpBot As String = "Help-Bot"


        Shared GB_Source As String = "Source"

        Shared MS_Source_BTN_File As String = "File"
        Shared MS_source_BTN_File_New As String = "New"
        Shared MS_Source_BTN_File_Open As String = "Open"

        Shared LBL_Source_Encoding As String = "Encoding :"

        Shared GB_Source_Data As String = "Data"
        Shared GB_Source_Data_Id As String = "ID"
        Shared GB_Source_Data_Content As String = "Content"

        Shared BTN_Source_Data_Previous As String = "Previous"
        Shared BTN_Source_Data_Next As String = "Next"

        Shared BTN_Source_Data_UseHelpBot As String = "Use Help-Bot"
        Shared BTN_Source_Data_Add As String = "Add"

        Shared GB_Source_List As String = "List"
        Shared LBL_Source_List_Total As String = "Total : "
        Shared LBL_Source_List_Selected As String = "Selected : "


        Shared GB_Dest As String = "Destination"

        Shared MS_Dest_BTN_File As String = "File"
        Shared MS_Dest_BTN_File_New As String = "New"
        Shared MS_Dest_BTN_File_Open As String = "Open"
        Shared MS_Dest_BTN_File_Save As String = "Save"
        Shared MS_Dest_BTN_File_SaveAs As String = "Save as ..."

        Shared LBL_Dest_Encoding As String = "Encoding :"

        Shared GB_Dest_Data As String = "Data"
        Shared GB_Dest_Data_Id As String = "ID"
        Shared GB_Dest_Data_Content As String = "Content"

        Shared BTN_Dest_Data_UseSource As String = "Use source"

        Shared BTN_Dest_Data_Delete As String = "Delete"
        Shared BTN_Dest_Data_Modify As String = "Modify"
        Shared BTN_Dest_Data_Add As String = "Add"

        Shared BTN_Dest_Data_UseHelpBot As String = "Use Help-Bot"


        Shared GB_Dest_List As String = "List"
        Shared LBL_Dest_List_Total As String = "Total : "
        Shared LBL_Dest_List_Selected As String = "Selected : "
#End Region

#Region "Fenêtre de recherche"
        Shared FindForm As String = "Search"

        Shared BTN_Ok As String = "Ok"

        Shared GB_Result As String = "Result"
        Shared LBL_ObjsFound As String = "Items found : "
        Shared LBL_SelectedObj As String = "Selected item : "

        Shared BTN_Previous As String = "Previous"
        Shared BTN_Next As String = "Next"
#End Region

#Region "Aide-Bot"
        Shared TP_Source As String = "Source"
        Shared BTN_Source_New As String = "New"

        Shared GB_Source_From As String = "From"
        Shared GB_Source_To As String = "To"

        Shared BTN_Source_Delete As String = "Delete"
        Shared BTN_Source_Modify As String = "Edit"
        Shared BTN_Source_Add As String = "Add"

        Shared BTN_Source_Open As String = "Open"
        Shared BTN_Source_Save As String = "Save"


        Shared TP_Dest As String = "Destination"
        Shared BTN_Dest_New As String = "New"

        Shared GB_Dest_From As String = "From"
        Shared GB_Dest_To As String = "To"

        Shared BTN_Dest_Delete As String = "Delete"
        Shared BTN_Dest_Modify As String = "Edit"
        Shared BTN_Dest_Add As String = "Add"

        Shared BTN_Dest_Open As String = "Open"
        Shared BTN_Dest_Save As String = "Save"
#End Region
    End Structure
    Structure French
#Region "Fenêtre maître"
        Shared MS_MainMenu_BTN_HelpBot As String = "Aide-Bot"


        Shared GB_Source As String = "Source"

        Shared MS_Source_BTN_File As String = "Fichier"
        Shared MS_source_BTN_File_New As String = "Nouveau"
        Shared MS_Source_BTN_File_Open As String = "Ouvrir"

        Shared LBL_Source_Encoding As String = "Encodage :"

        Shared GB_Source_Data As String = "Données"
        Shared GB_Source_Data_Id As String = "ID"
        Shared GB_Source_Data_Content As String = "Contenu"

        Shared BTN_Source_Data_Previous As String = "Précédent"
        Shared BTN_Source_Data_Next As String = "Suivant"

        Shared BTN_Source_Data_UseHelpBot As String = "Utiliser l'Aide-Bot"
        Shared BTN_Source_Data_Add As String = "Ajouter"

        Shared GB_Source_List As String = "Liste"
        Shared LBL_Source_List_Total As String = "Total : "
        Shared LBL_Source_List_Selected As String = "Sélectionné : "


        Shared GB_Dest As String = "Destination"

        Shared MS_Dest_BTN_File As String = "Fichier"
        Shared MS_Dest_BTN_File_New As String = "Nouveau"
        Shared MS_Dest_BTN_File_Open As String = "Ouvrir"
        Shared MS_Dest_BTN_File_Save As String = "Enregistrer"
        Shared MS_Dest_BTN_File_SaveAs As String = "Enregistrer sous ..."

        Shared LBL_Dest_Encoding As String = "Encodage :"

        Shared GB_Dest_Data As String = "Données"
        Shared GB_Dest_Data_Id As String = "ID"
        Shared GB_Dest_Data_Content As String = "Contenu"

        Shared BTN_Dest_Data_UseSource As String = "Utiliser source"

        Shared BTN_Dest_Data_Delete As String = "Supprimer"
        Shared BTN_Dest_Data_Modify As String = "Modifier"
        Shared BTN_Dest_Data_Add As String = "Ajouter"

        Shared BTN_Dest_Data_UseHelpBot As String = "Utiliser l'Aide-Bot"


        Shared GB_Dest_List As String = "Liste"
        Shared LBL_Dest_List_Total As String = "Total : "
        Shared LBL_Dest_List_Selected As String = "Sélectionné : "
#End Region

#Region "Fenêtre de recherche"
        Shared FindForm As String = "Rechercher"

        Shared BTN_Ok As String = "Ok"

        Shared GB_Result As String = "Résultat"
        Shared LBL_ObjsFound As String = "Objets trouvé : "
        Shared LBL_SelectedObj As String = "Objet sélectionné : "

        Shared BTN_Previous As String = "Précédent"
        Shared BTN_Next As String = "Suivant"
#End Region

#Region "Aide-Bot"
        Shared TP_Source As String = "Source"
        Shared BTN_Source_New As String = "Nouveau"

        Shared GB_Source_From As String = "De"
        Shared GB_Source_To As String = "À"

        Shared BTN_Source_Delete As String = "Supprimer"
        Shared BTN_Source_Modify As String = "Modifier"
        Shared BTN_Source_Add As String = "Ajouter"

        Shared BTN_Source_Open As String = "Ouvrir"
        Shared BTN_Source_Save As String = "Sauvegarder"


        Shared TP_Dest As String = "Destination"
        Shared BTN_Dest_New As String = "Nouveau"

        Shared GB_Dest_From As String = "De"
        Shared GB_Dest_To As String = "À"

        Shared BTN_Dest_Delete As String = "Supprimer"
        Shared BTN_Dest_Modify As String = "Modifier"
        Shared BTN_Dest_Add As String = "Ajouter"

        Shared BTN_Dest_Open As String = "Ouvrir"
        Shared BTN_Dest_Save As String = "Sauvegarder"
#End Region
    End Structure
    Structure Russian
#Region "Fenêtre maître"
        Shared MS_MainMenu_BTN_HelpBot As String = "бот-помощник"


        Shared GB_Source As String = "Источник"

        Shared MS_Source_BTN_File As String = "Файл"
        Shared MS_source_BTN_File_New As String = "Новый"
        Shared MS_Source_BTN_File_Open As String = "Открыть"

        Shared LBL_Source_Encoding As String = "Кодирование :"

        Shared GB_Source_Data As String = "Данные"
        Shared GB_Source_Data_Id As String = "ID"
        Shared GB_Source_Data_Content As String = "Содержание"

        Shared BTN_Source_Data_Previous As String = "Предыдущий"
        Shared BTN_Source_Data_Next As String = "Следующий"

        Shared BTN_Source_Data_UseHelpBot As String = "Использование бота-помощника"
        Shared BTN_Source_Data_Add As String = "Добавить"

        Shared GB_Source_List As String = "Список"
        Shared LBL_Source_List_Total As String = "Всего : "
        Shared LBL_Source_List_Selected As String = "Избранное : "


        Shared GB_Dest As String = "Место назначения"

        Shared MS_Dest_BTN_File As String = "Файл"
        Shared MS_Dest_BTN_File_New As String = "Новый"
        Shared MS_Dest_BTN_File_Open As String = "Открыть"
        Shared MS_Dest_BTN_File_Save As String = "Зарегистрироваться"
        Shared MS_Dest_BTN_File_SaveAs As String = "Сохранить как ..."

        Shared LBL_Dest_Encoding As String = "Кодирование :"

        Shared GB_Dest_Data As String = "Данные"
        Shared GB_Dest_Data_Id As String = "ID"
        Shared GB_Dest_Data_Content As String = "Содержание"

        Shared BTN_Dest_Data_UseSource As String = "Используйте источник"

        Shared BTN_Dest_Data_Delete As String = "Удалить"
        Shared BTN_Dest_Data_Modify As String = "Редактирование"
        Shared BTN_Dest_Data_Add As String = "Добавить"

        Shared BTN_Dest_Data_UseHelpBot As String = "Использование бота-помощника"


        Shared GB_Dest_List As String = "Список"
        Shared LBL_Dest_List_Total As String = "Всего : "
        Shared LBL_Dest_List_Selected As String = "Избранное : "
#End Region

#Region "Fenêtre de recherche"
        Shared FindForm As String = "Поиск"

        Shared BTN_Ok As String = "Хорошо"

        Shared GB_Result As String = "Результат"
        Shared LBL_ObjsFound As String = "Найдено товаров : "
        Shared LBL_SelectedObj As String = "Выбранный объект : "

        Shared BTN_Previous As String = "Предыдущий"
        Shared BTN_Next As String = "Следующий"
#End Region

#Region "Aide-Bot"
        Shared TP_Source As String = "Источник"
        Shared BTN_Source_New As String = "Новый"

        Shared GB_Source_From As String = "С сайта"
        Shared GB_Source_To As String = "на адрес"

        Shared BTN_Source_Delete As String = "Удалить"
        Shared BTN_Source_Modify As String = "Редактировать"
        Shared BTN_Source_Add As String = "Добавить"

        Shared BTN_Source_Open As String = "Открыть"
        Shared BTN_Source_Save As String = "Сохранить"


        Shared TP_Dest As String = "Место назначения"
        Shared BTN_Dest_New As String = "Новый"

        Shared GB_Dest_From As String = "С сайта"
        Shared GB_Dest_To As String = "на адрес"

        Shared BTN_Dest_Delete As String = "Удалить"
        Shared BTN_Dest_Modify As String = "Редактировать"
        Shared BTN_Dest_Add As String = "Добавить"

        Shared BTN_Dest_Open As String = "Открыть"
        Shared BTN_Dest_Save As String = "Сохранить"
#End Region
    End Structure
End Module
