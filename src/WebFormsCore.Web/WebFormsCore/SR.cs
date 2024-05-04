﻿#region Assembly System.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.8\System.Web.dll
// Decompiled with ICSharpCode.Decompiler 8.1.1.7464
#endregion

using System.Globalization;
using System.Resources;
using System.Threading;

namespace System.Web;

internal sealed class SR
{
	internal const string Parameter_Invalid = "Parameter_Invalid";

	internal const string Parameter_NullOrEmpty = "Parameter_NullOrEmpty";

	internal const string Property_NullOrEmpty = "Property_NullOrEmpty";

	internal const string Property_Invalid = "Property_Invalid";

	internal const string Unexpected_Error = "Unexpected_Error";

	internal const string PropertyCannotBeNullOrEmptyString = "PropertyCannotBeNullOrEmptyString";

	internal const string PropertyCannotBeNull = "PropertyCannotBeNull";

	internal const string Invalid_string_from_browser_caps = "Invalid_string_from_browser_caps";

	internal const string Unrecognized_construct_in_pattern = "Unrecognized_construct_in_pattern";

	internal const string Caps_cannot_be_inited_twice = "Caps_cannot_be_inited_twice";

	internal const string Duplicate_browser_id = "Duplicate_browser_id";

	internal const string Invalid_browser_root = "Invalid_browser_root";

	internal const string Browser_mutually_exclusive_attributes = "Browser_mutually_exclusive_attributes";

	internal const string Browser_refid_prohibits_identification = "Browser_refid_prohibits_identification";

	internal const string Browser_invalid_element = "Browser_invalid_element";

	internal const string Browser_Circular_Reference = "Browser_Circular_Reference";

	internal const string Browser_attributes_required = "Browser_attributes_required";

	internal const string Browser_parentID_Not_Found = "Browser_parentID_Not_Found";

	internal const string Browser_parentID_applied_to_default = "Browser_parentID_applied_to_default";

	internal const string Browser_InvalidID = "Browser_InvalidID";

	internal const string Browser_Not_Allowed_InAppLevel = "Browser_Not_Allowed_InAppLevel";

	internal const string Browser_InvalidStrongNameKey = "Browser_InvalidStrongNameKey";

	internal const string Browser_compile_error = "Browser_compile_error";

	internal const string DefaultBrowser_parentID_Not_Found = "DefaultBrowser_parentID_Not_Found";

	internal const string Browser_empty_identification = "Browser_empty_identification";

	internal const string Browser_W3SVC_Failure_Helper_Text = "Browser_W3SVC_Failure_Helper_Text";

	internal const string DefaultSiteName = "DefaultSiteName";

	internal const string ControlAdapters_TypeNotFound = "ControlAdapters_TypeNotFound";

	internal const string Failed_gac_install = "Failed_gac_install";

	internal const string Failed_gac_uninstall = "Failed_gac_uninstall";

	internal const string WrongType_of_Protected_provider = "WrongType_of_Protected_provider";

	internal const string Make_sure_remote_server_is_enabled_for_config_access = "Make_sure_remote_server_is_enabled_for_config_access";

	internal const string Config_unable_to_get_section = "Config_unable_to_get_section";

	internal const string Config_failed_to_resolve_site_id = "Config_failed_to_resolve_site_id";

	internal const string Config_GetSectionWithPathArgInvalid = "Config_GetSectionWithPathArgInvalid";

	internal const string Unable_to_create_temp_file = "Unable_to_create_temp_file";

	internal const string Config_allow_definition_error_application = "Config_allow_definition_error_application";

	internal const string Config_allow_definition_error_machine = "Config_allow_definition_error_machine";

	internal const string Config_allow_definition_error_webroot = "Config_allow_definition_error_webroot";

	internal const string Config_base_unrecognized_element = "Config_base_unrecognized_element";

	internal const string Config_base_required_attribute_missing = "Config_base_required_attribute_missing";

	internal const string Config_base_required_attribute_empty = "Config_base_required_attribute_empty";

	internal const string Config_base_unrecognized_attribute = "Config_base_unrecognized_attribute";

	internal const string Config_base_elements_only = "Config_base_elements_only";

	internal const string Config_base_no_child_nodes = "Config_base_no_child_nodes";

	internal const string Config_base_file_load_exception_no_message = "Config_base_file_load_exception_no_message";

	internal const string Config_base_bad_image_exception_no_message = "Config_base_bad_image_exception_no_message";

	internal const string Config_base_report_exception_type = "Config_base_report_exception_type";

	internal const string Config_property_generic = "Config_property_generic";

	internal const string Config_section_not_supported = "Config_section_not_supported";

	internal const string Unable_To_Register_Assembly = "Unable_To_Register_Assembly";

	internal const string Unable_To_UnRegister_Assembly = "Unable_To_UnRegister_Assembly";

	internal const string Could_not_create_type_instance = "Could_not_create_type_instance";

	internal const string Config_Invalid_enum_value = "Config_Invalid_enum_value";

	internal const string Config_element_below_app_illegal = "Config_element_below_app_illegal";

	internal const string Config_provider_must_exist = "Config_provider_must_exist";

	internal const string File_is_read_only = "File_is_read_only";

	internal const string Can_not_access_files_other_than_config = "Can_not_access_files_other_than_config";

	internal const string Error_loading_XML_file = "Error_loading_XML_file";

	internal const string Unknown_tag_in_caps_config = "Unknown_tag_in_caps_config";

	internal const string Cannot_specify_test_without_match = "Cannot_specify_test_without_match";

	internal const string Result_must_be_at_the_top_browser_section = "Result_must_be_at_the_top_browser_section";

	internal const string Type_doesnt_inherit_from_type = "Type_doesnt_inherit_from_type";

	internal const string Type_cannot_be_resolved = "Type_cannot_be_resolved";

	internal const string Problem_reading_caps_config = "Problem_reading_caps_config";

	internal const string Special_module_cannot_be_added_manually = "Special_module_cannot_be_added_manually";

	internal const string Special_module_cannot_be_removed_manually = "Special_module_cannot_be_removed_manually";

	internal const string Module_not_in_app = "Module_not_in_app";

	internal const string Invalid_credentials = "Invalid_credentials";

	internal const string Auth_Invalid_Login_Url = "Auth_Invalid_Login_Url";

	internal const string Invalid_value_for_globalization_attr = "Invalid_value_for_globalization_attr";

	internal const string Invalid_credentials_2 = "Invalid_credentials_2";

	internal const string Invalid_registry_config = "Invalid_registry_config";

	internal const string Invalid_Passport_Redirect_URL = "Invalid_Passport_Redirect_URL";

	internal const string Invalid_redirect_return_url = "Invalid_redirect_return_url";

	internal const string Config_section_not_present = "Config_section_not_present";

	internal const string Local_free_threads_cannot_exceed_free_threads = "Local_free_threads_cannot_exceed_free_threads";

	internal const string Min_free_threads_must_be_under_thread_pool_limits = "Min_free_threads_must_be_under_thread_pool_limits";

	internal const string Thread_pool_limit_must_be_greater_than_minFreeThreads = "Thread_pool_limit_must_be_greater_than_minFreeThreads";

	internal const string Config_max_request_length_disk_threshold_exceeds_max_request_length = "Config_max_request_length_disk_threshold_exceeds_max_request_length";

	internal const string Config_max_request_length_smaller_than_max_request_length_disk_threshold = "Config_max_request_length_smaller_than_max_request_length_disk_threshold";

	internal const string Capability_file_root_element = "Capability_file_root_element";

	internal const string File_element_only_valid_in_config = "File_element_only_valid_in_config";

	internal const string HttpRuntimeSection_TargetFramework_Invalid = "HttpRuntimeSection_TargetFramework_Invalid";

	internal const string Clear_not_valid = "Clear_not_valid";

	internal const string Config_base_cannot_remove_inherited_items = "Config_base_cannot_remove_inherited_items";

	internal const string Nested_group_not_valid = "Nested_group_not_valid";

	internal const string Dup_protocol_id = "Dup_protocol_id";

	internal const string WebPartsSection_NoVerbs = "WebPartsSection_NoVerbs";

	internal const string WebPartsSection_InvalidVerb = "WebPartsSection_InvalidVerb";

	internal const string Transformer_types_already_added = "Transformer_types_already_added";

	internal const string Transformer_attribute_error = "Transformer_attribute_error";

	internal const string File_changed_since_read = "File_changed_since_read";

	internal const string Config_invalid_element = "Config_invalid_element";

	internal const string Config_control_rendering_compatibility_version_is_less_than_minimum_version = "Config_control_rendering_compatibility_version_is_less_than_minimum_version";

	internal const string InvalidExpressionSyntax = "InvalidExpressionSyntax";

	internal const string InvalidExpressionPrefix = "InvalidExpressionPrefix";

	internal const string ExpressionBuilder_InvalidType = "ExpressionBuilder_InvalidType";

	internal const string MissingExpressionPrefix = "MissingExpressionPrefix";

	internal const string MissingExpressionValue = "MissingExpressionValue";

	internal const string ExpressionBuilder_LiteralExpressionsNotAllowed = "ExpressionBuilder_LiteralExpressionsNotAllowed";

	internal const string ResourceExpresionBuilder_PageResourceNotFound = "ResourceExpresionBuilder_PageResourceNotFound";

	internal const string Failed_to_start_monitoring = "Failed_to_start_monitoring";

	internal const string Invalid_file_name_for_monitoring = "Invalid_file_name_for_monitoring";

	internal const string Access_denied_for_monitoring = "Access_denied_for_monitoring";

	internal const string Directory_does_not_exist_for_monitoring = "Directory_does_not_exist_for_monitoring";

	internal const string NetBios_command_limit_reached = "NetBios_command_limit_reached";

	internal const string Directory_rename_notification = "Directory_rename_notification";

	internal const string Change_notification_critical_dir = "Change_notification_critical_dir";

	internal const string Path_not_found = "Path_not_found";

	internal const string Path_forbidden = "Path_forbidden";

	internal const string Method_for_path_not_implemented = "Method_for_path_not_implemented";

	internal const string Method_not_allowed = "Method_not_allowed";

	internal const string Cannot_call_defaulthttphandler_sync = "Cannot_call_defaulthttphandler_sync";

	internal const string Handler_access_denied = "Handler_access_denied";

	internal const string Debugging_forbidden = "Debugging_forbidden";

	internal const string Debug_Access_Denied = "Debug_Access_Denied";

	internal const string Invalid_Debug_Request = "Invalid_Debug_Request";

	internal const string Invalid_Debug_ID = "Invalid_Debug_ID";

	internal const string Error_Attaching_with_MDM = "Error_Attaching_with_MDM";

	internal const string VaryByCustom_already_set = "VaryByCustom_already_set";

	internal const string CacheProfile_Not_Found = "CacheProfile_Not_Found";

	internal const string Invalid_operation_cache_dependency = "Invalid_operation_cache_dependency";

	internal const string Invalid_sqlDependency_argument = "Invalid_sqlDependency_argument";

	internal const string Invalid_sqlDependency_argument2 = "Invalid_sqlDependency_argument2";

	internal const string Etag_already_set = "Etag_already_set";

	internal const string Cant_both_set_and_generate_Etag = "Cant_both_set_and_generate_Etag";

	internal const string Cacheability_for_field_must_be_private_or_nocache = "Cacheability_for_field_must_be_private_or_nocache";

	internal const string Cache_dependency_used_more_that_once = "Cache_dependency_used_more_that_once";

	internal const string Invalid_expiration_combination = "Invalid_expiration_combination";

	internal const string Invalid_Dependency_Type = "Invalid_Dependency_Type";

	internal const string Invalid_Parameters_To_Insert = "Invalid_Parameters_To_Insert";

	internal const string Invalid_sql_cache_dep_polltime = "Invalid_sql_cache_dep_polltime";

	internal const string Database_not_found = "Database_not_found";

	internal const string Cant_connect_sql_cache_dep_database_polling = "Cant_connect_sql_cache_dep_database_polling";

	internal const string Cant_connect_sql_cache_dep_database_admin = "Cant_connect_sql_cache_dep_database_admin";

	internal const string Cant_connect_sql_cache_dep_database_admin_cmdtxt = "Cant_connect_sql_cache_dep_database_admin_cmdtxt";

	internal const string Database_not_enabled_for_notification = "Database_not_enabled_for_notification";

	internal const string Table_not_enabled_for_notification = "Table_not_enabled_for_notification";

	internal const string Polling_not_enabled_for_sql_cache = "Polling_not_enabled_for_sql_cache";

	internal const string Polltime_zero_for_database_sql_cache = "Polltime_zero_for_database_sql_cache";

	internal const string Permission_denied_database_polling = "Permission_denied_database_polling";

	internal const string Permission_denied_database_enable_notification = "Permission_denied_database_enable_notification";

	internal const string Permission_denied_table_enable_notification = "Permission_denied_table_enable_notification";

	internal const string Permission_denied_database_disable_notification = "Permission_denied_database_disable_notification";

	internal const string Permission_denied_table_disable_notification = "Permission_denied_table_disable_notification";

	internal const string Cant_get_enabled_tables_sql_cache_dep = "Cant_get_enabled_tables_sql_cache_dep";

	internal const string Cant_disable_table_sql_cache_dep = "Cant_disable_table_sql_cache_dep";

	internal const string Cache_null_table = "Cache_null_table";

	internal const string Cache_null_table_in_tables = "Cache_null_table_in_tables";

	internal const string Cache_dep_table_not_found = "Cache_dep_table_not_found";

	internal const string UC_not_cached = "UC_not_cached";

	internal const string UCCachePolicy_unavailable = "UCCachePolicy_unavailable";

	internal const string SqlCacheDependency_permission_denied = "SqlCacheDependency_permission_denied";

	internal const string No_UniqueId_Cache_Dependency = "No_UniqueId_Cache_Dependency";

	internal const string SqlCacheDependency_OutputCache_Conflict = "SqlCacheDependency_OutputCache_Conflict";

	internal const string Cache_not_available = "Cache_not_available";

	internal const string Http_handler_not_found_for_request_type = "Http_handler_not_found_for_request_type";

	internal const string Request_not_available = "Request_not_available";

	internal const string Response_not_available = "Response_not_available";

	internal const string Session_not_available = "Session_not_available";

	internal const string Server_not_available = "Server_not_available";

	internal const string User_not_available = "User_not_available";

	internal const string Sync_not_supported = "Sync_not_supported";

	internal const string Type_not_factory_or_handler = "Type_not_factory_or_handler";

	internal const string Type_from_untrusted_assembly = "Type_from_untrusted_assembly";

	internal const string Type_not_module = "Type_not_module";

	internal const string Request_timed_out = "Request_timed_out";

	internal const string DynamicModuleRegistrationOff = "DynamicModuleRegistrationOff";

	internal const string Invalid_ControlState = "Invalid_ControlState";

	internal const string Too_late_for_ViewStateUserKey = "Too_late_for_ViewStateUserKey";

	internal const string Too_late_for_RegisterRequiresViewStateEncryption = "Too_late_for_RegisterRequiresViewStateEncryption";

	internal const string MethodCannotBeCalledAfterAppStart = "MethodCannotBeCalledAfterAppStart";

	internal const string Invalid_urlencoded_form_data = "Invalid_urlencoded_form_data";

	internal const string Invalid_request_filter = "Invalid_request_filter";

	internal const string Cannot_map_path_without_context = "Cannot_map_path_without_context";

	internal const string Cross_app_not_allowed = "Cross_app_not_allowed";

	internal const string Max_request_length_exceeded = "Max_request_length_exceeded";

	internal const string Dangerous_input_detected = "Dangerous_input_detected";

	internal const string Dangerous_input_detected_descr = "Dangerous_input_detected_descr";

	internal const string CollectionCountExceeded_HttpValueCollection = "CollectionCountExceeded_HttpValueCollection";

	internal const string CollectionCountExceeded_JavaScriptObjectDeserializer = "CollectionCountExceeded_JavaScriptObjectDeserializer";

	internal const string Invalid_substitution_callback = "Invalid_substitution_callback";

	internal const string Url_too_long = "Url_too_long";

	internal const string QueryString_too_long = "QueryString_too_long";

	internal const string Using_BufferlessStream_API_Not_Supported = "Using_BufferlessStream_API_Not_Supported";

	internal const string Using_InputStream_API_Not_Supported = "Using_InputStream_API_Not_Supported";

	internal const string Cannot_get_snapshot_if_not_buffered = "Cannot_get_snapshot_if_not_buffered";

	internal const string Cannot_use_snapshot_after_headers_sent = "Cannot_use_snapshot_after_headers_sent";

	internal const string Cannot_use_snapshot_for_TextWriter = "Cannot_use_snapshot_for_TextWriter";

	internal const string Cannot_set_status_after_headers_sent = "Cannot_set_status_after_headers_sent";

	internal const string Cannot_set_content_type_after_headers_sent = "Cannot_set_content_type_after_headers_sent";

	internal const string Filtering_not_allowed = "Filtering_not_allowed";

	internal const string Cannot_append_header_after_headers_sent = "Cannot_append_header_after_headers_sent";

	internal const string Cannot_append_cookie_after_headers_sent = "Cannot_append_cookie_after_headers_sent";

	internal const string Cannot_modify_cookies_after_headers_sent = "Cannot_modify_cookies_after_headers_sent";

	internal const string Cannot_clear_headers_after_headers_sent = "Cannot_clear_headers_after_headers_sent";

	internal const string Cannot_call_method_after_headers_sent_generic = "Cannot_call_method_after_headers_sent_generic";

	internal const string Cannot_flush_completed_response = "Cannot_flush_completed_response";

	internal const string No_Route_Found_For_Redirect = "No_Route_Found_For_Redirect";

	internal const string Cannot_redirect_after_headers_sent = "Cannot_redirect_after_headers_sent";

	internal const string Cannot_set_header_encoding_after_headers_sent = "Cannot_set_header_encoding_after_headers_sent";

	internal const string Invalid_header_encoding = "Invalid_header_encoding";

	internal const string Cannot_redirect_to_newline = "Cannot_redirect_to_newline";

	internal const string Invalid_status_string = "Invalid_status_string";

	internal const string Invalid_value_for_CacheControl = "Invalid_value_for_CacheControl";

	internal const string OutputStream_NotAvail = "OutputStream_NotAvail";

	internal const string Information_Disclosure_Warning = "Information_Disclosure_Warning";

	internal const string InvalidOffsetOrCount = "InvalidOffsetOrCount";

	internal const string Invalid_path_for_push_promise = "Invalid_path_for_push_promise";

	internal const string Access_denied_to_app_dir = "Access_denied_to_app_dir";

	internal const string Access_denied_to_unicode_app_dir = "Access_denied_to_unicode_app_dir";

	internal const string Access_denied_to_path = "Access_denied_to_path";

	internal const string Insufficient_trust_for_attribute = "Insufficient_trust_for_attribute";

	internal const string XSP_init_error = "XSP_init_error";

	internal const string Unable_create_app_object = "Unable_create_app_object";

	internal const string Could_not_create_type = "Could_not_create_type";

	internal const string StateManagedCollection_InvalidIndex = "StateManagedCollection_InvalidIndex";

	internal const string StateManagedCollection_NoKnownTypes = "StateManagedCollection_NoKnownTypes";

	internal const string VirtualPath_Length_Zero = "VirtualPath_Length_Zero";

	internal const string Invalid_app_VirtualPath = "Invalid_app_VirtualPath";

	internal const string Collection_CantAddNull = "Collection_CantAddNull";

	internal const string Collection_InvalidType = "Collection_InvalidType";

	internal const string VirtualPath_AllowAppRelativePath = "VirtualPath_AllowAppRelativePath";

	internal const string VirtualPath_AllowRelativePath = "VirtualPath_AllowRelativePath";

	internal const string VirtualPath_AllowAbsolutePath = "VirtualPath_AllowAbsolutePath";

	internal const string VirtualPath_CantMakeAppRelative = "VirtualPath_CantMakeAppRelative";

	internal const string VirtualPath_CantMakeAppAbsolute = "VirtualPath_CantMakeAppAbsolute";

	internal const string Bad_VirtualPath_in_VirtualFileBase = "Bad_VirtualPath_in_VirtualFileBase";

	internal const string ControlRenderedOutsideServerForm = "ControlRenderedOutsideServerForm";

	internal const string RequiresNT = "RequiresNT";

	internal const string ListEnumVersionMismatch = "ListEnumVersionMismatch";

	internal const string ListEnumCurrentOutOfRange = "ListEnumCurrentOutOfRange";

	internal const string HTMLTextWriterUnbalancedPop = "HTMLTextWriterUnbalancedPop";

	internal const string Server_too_busy = "Server_too_busy";

	internal const string InvalidArgumentValue = "InvalidArgumentValue";

	internal const string CompilationMutex_Create = "CompilationMutex_Create";

	internal const string CompilationMutex_Null = "CompilationMutex_Null";

	internal const string CompilationMutex_Drained = "CompilationMutex_Drained";

	internal const string CompilationMutex_Failed = "CompilationMutex_Failed";

	internal const string Failed_to_create_temp_dir = "Failed_to_create_temp_dir";

	internal const string Failed_to_execute_child_request = "Failed_to_execute_child_request";

	internal const string Cannot_impersonate = "Cannot_impersonate";

	internal const string No_codegen_access = "No_codegen_access";

	internal const string Transaction_not_supported_in_low_trust = "Transaction_not_supported_in_low_trust";

	internal const string Debugging_not_supported_in_low_trust = "Debugging_not_supported_in_low_trust";

	internal const string Session_state_need_higher_trust = "Session_state_need_higher_trust";

	internal const string ExecuteUrl_not_supported = "ExecuteUrl_not_supported";

	internal const string Cannot_execute_url_in_this_context = "Cannot_execute_url_in_this_context";

	internal const string Failed_to_execute_url = "Failed_to_execute_url";

	internal const string Aspnet_not_installed = "Aspnet_not_installed";

	internal const string Failed_to_initialize_AppDomain = "Failed_to_initialize_AppDomain";

	internal const string Cannot_create_AppDomain = "Cannot_create_AppDomain";

	internal const string Cannot_create_HostEnv = "Cannot_create_HostEnv";

	internal const string Unknown_protocol_id = "Unknown_protocol_id";

	internal const string Only_1_HostEnv = "Only_1_HostEnv";

	internal const string Not_IRegisteredObject = "Not_IRegisteredObject";

	internal const string Wellknown_object_already_exists = "Wellknown_object_already_exists";

	internal const string Invalid_IIS_app = "Invalid_IIS_app";

	internal const string App_Virtual_Path = "App_Virtual_Path";

	internal const string Hosting_Phys_Path_Changed = "Hosting_Phys_Path_Changed";

	internal const string App_Domain_Restart = "App_Domain_Restart";

	internal const string Hosting_Env_Restart = "Hosting_Env_Restart";

	internal const string Hosting_Env_IdleTimeout = "Hosting_Env_IdleTimeout";

	internal const string Unhandled_Exception = "Unhandled_Exception";

	internal const string Provider_must_implement_the_interface = "Provider_must_implement_the_interface";

	internal const string Permission_set_not_found = "Permission_set_not_found";

	internal const string Require_stable_string_hash_codes = "Require_stable_string_hash_codes";

	internal const string Server_variable_cannot_be_modified = "Server_variable_cannot_be_modified";

	internal const string Cache_url_invalid = "Cache_url_invalid";

	internal const string Invalid_range = "Invalid_range";

	internal const string Invalid_use_of_response_filter = "Invalid_use_of_response_filter";

	internal const string Invalid_response_filter = "Invalid_response_filter";

	internal const string Invalid_size = "Invalid_size";

	internal const string Process_information_not_available = "Process_information_not_available";

	internal const string Error_trying_to_enumerate_files = "Error_trying_to_enumerate_files";

	internal const string File_enumerator_access_denied = "File_enumerator_access_denied";

	internal const string File_does_not_exist = "File_does_not_exist";

	internal const string File_is_hidden = "File_is_hidden";

	internal const string Missing_star_mapping = "Missing_star_mapping";

	internal const string Resource_access_forbidden = "Resource_access_forbidden";

	internal const string SMTP_TypeCreationError = "SMTP_TypeCreationError";

	internal const string Could_not_create_object_of_type = "Could_not_create_object_of_type";

	internal const string Could_not_create_object_from_clsid = "Could_not_create_object_from_clsid";

	internal const string Error_executing_child_request_for_path = "Error_executing_child_request_for_path";

	internal const string Error_executing_child_request_for_handler = "Error_executing_child_request_for_handler";

	internal const string Invalid_path_for_child_request = "Invalid_path_for_child_request";

	internal const string Transacted_page_calls_aspcompat = "Transacted_page_calls_aspcompat";

	internal const string Invalid_path_for_remove = "Invalid_path_for_remove";

	internal const string Get_computer_name_failed = "Get_computer_name_failed";

	internal const string Cannot_map_path = "Cannot_map_path";

	internal const string Cannot_access_mappath_title = "Cannot_access_mappath_title";

	internal const string Cannot_access_mappath_details = "Cannot_access_mappath_details";

	internal const string Cannot_retrieve_request_data = "Cannot_retrieve_request_data";

	internal const string Cannot_read_posted_data = "Cannot_read_posted_data";

	internal const string Cannot_get_query_string = "Cannot_get_query_string";

	internal const string Cannot_get_query_string_bytes = "Cannot_get_query_string_bytes";

	internal const string Not_supported = "Not_supported";

	internal const string GetGacLocaltion_failed = "GetGacLocaltion_failed";

	internal const string Server_Support_Function_Error = "Server_Support_Function_Error";

	internal const string Server_Support_Function_Error_Disconnect = "Server_Support_Function_Error_Disconnect";

	internal const string MachineKeyDataProtectorFactory_FactoryCreationFailed = "MachineKeyDataProtectorFactory_FactoryCreationFailed";

	internal const string MachineKey_InvalidPurpose = "MachineKey_InvalidPurpose";

	internal const string Provider_Schema_Version_Not_Match = "Provider_Schema_Version_Not_Match";

	internal const string Could_not_create_passport_identity = "Could_not_create_passport_identity";

	internal const string Passport_method_failed = "Passport_method_failed";

	internal const string Auth_rule_names_cant_contain_char = "Auth_rule_names_cant_contain_char";

	internal const string Auth_rule_must_specify_users_andor_roles = "Auth_rule_must_specify_users_andor_roles";

	internal const string PageIndex_bad = "PageIndex_bad";

	internal const string PageSize_bad = "PageSize_bad";

	internal const string PageIndex_PageSize_bad = "PageIndex_PageSize_bad";

	internal const string Bad_machine_key = "Bad_machine_key";

	internal const string PassportAuthFailed = "PassportAuthFailed";

	internal const string PassportAuthFailed_Title = "PassportAuthFailed_Title";

	internal const string PassportAuthFailed_Description = "PassportAuthFailed_Description";

	internal const string Unable_to_encrypt_cookie_ticket = "Unable_to_encrypt_cookie_ticket";

	internal const string Unable_to_get_cookie_authentication_validation_key = "Unable_to_get_cookie_authentication_validation_key";

	internal const string Unable_to_validate_data = "Unable_to_validate_data";

	internal const string Unable_to_get_policy_file = "Unable_to_get_policy_file";

	internal const string Wrong_validation_enum = "Wrong_validation_enum";

	internal const string Wrong_validation_enum_FX45 = "Wrong_validation_enum_FX45";

	internal const string Wrong_decryption_enum = "Wrong_decryption_enum";

	internal const string Role_is_not_empty = "Role_is_not_empty";

	internal const string Assess_Denied_Title = "Assess_Denied_Title";

	internal const string Assess_Denied_Description2 = "Assess_Denied_Description2";

	internal const string Assess_Denied_Section_Title2 = "Assess_Denied_Section_Title2";

	internal const string Assess_Denied_Misc_Content2 = "Assess_Denied_Misc_Content2";

	internal const string Assess_Denied_Description1 = "Assess_Denied_Description1";

	internal const string Assess_Denied_MiscTitle1 = "Assess_Denied_MiscTitle1";

	internal const string Assess_Denied_MiscContent1 = "Assess_Denied_MiscContent1";

	internal const string Assess_Denied_Description3 = "Assess_Denied_Description3";

	internal const string Assess_Denied_Section_Title3 = "Assess_Denied_Section_Title3";

	internal const string Assess_Denied_Misc_Content3 = "Assess_Denied_Misc_Content3";

	internal const string Assess_Denied_Misc_Content3_2 = "Assess_Denied_Misc_Content3_2";

	internal const string Auth_bad_url = "Auth_bad_url";

	internal const string Virtual_path_outside_application_not_supported = "Virtual_path_outside_application_not_supported";

	internal const string Invalid_decryption_key = "Invalid_decryption_key";

	internal const string Invalid_validation_key = "Invalid_validation_key";

	internal const string Passport_not_installed = "Passport_not_installed";

	internal const string DbFileName_can_not_contain_invalid_chars = "DbFileName_can_not_contain_invalid_chars";

	internal const string Provider_can_not_create_file_in_this_trust_level = "Provider_can_not_create_file_in_this_trust_level";

	internal const string LocalDB_cannot_have_userinstance_flag = "LocalDB_cannot_have_userinstance_flag";

	internal const string MembershipPasswordAttribute_InvalidPasswordLength = "MembershipPasswordAttribute_InvalidPasswordLength";

	internal const string MembershipPasswordAttribute_InvalidPasswordNonAlphanumericCharacters = "MembershipPasswordAttribute_InvalidPasswordNonAlphanumericCharacters";

	internal const string MembershipPasswordAttribute_InvalidPasswordStrength = "MembershipPasswordAttribute_InvalidPasswordStrength";

	internal const string MembershipPasswordAttribute_InvalidRegularExpression = "MembershipPasswordAttribute_InvalidRegularExpression";

	internal const string LocalizableString_LocalizationFailed = "LocalizableString_LocalizationFailed";

	internal const string Role_provider_name_invalid = "Role_provider_name_invalid";

	internal const string Def_provider_not_found = "Def_provider_not_found";

	internal const string Provider_no_type_name = "Provider_no_type_name";

	internal const string MembershipSqlProvider_description = "MembershipSqlProvider_description";

	internal const string RoleSqlProvider_description = "RoleSqlProvider_description";

	internal const string RoleAuthStoreProvider_description = "RoleAuthStoreProvider_description";

	internal const string RoleWindowsTokenProvider_description = "RoleWindowsTokenProvider_description";

	internal const string ProfileSqlProvider_description = "ProfileSqlProvider_description";

	internal const string Role_Principal_not_fully_constructed = "Role_Principal_not_fully_constructed";

	internal const string Only_one_connection_string_allowed = "Only_one_connection_string_allowed";

	internal const string Must_specify_connection_string_or_name = "Must_specify_connection_string_or_name";

	internal const string Cannot_use_integrated_security = "Cannot_use_integrated_security";

	internal const string Provider_application_name_too_long = "Provider_application_name_too_long";

	internal const string Provider_bad_password_format = "Provider_bad_password_format";

	internal const string Provider_can_not_retrieve_hashed_password = "Provider_can_not_retrieve_hashed_password";

	internal const string Provider_unrecognized_attribute = "Provider_unrecognized_attribute";

	internal const string Provider_can_not_decode_hashed_password = "Provider_can_not_decode_hashed_password";

	internal const string Profile_group_not_found = "Profile_group_not_found";

	internal const string Profile_not_enabled = "Profile_not_enabled";

	internal const string API_supported_for_current_user_only = "API_supported_for_current_user_only";

	internal const string API_failed_due_to_error = "API_failed_due_to_error";

	internal const string Profile_property_already_added = "Profile_property_already_added";

	internal const string Profile_provider_not_found = "Profile_provider_not_found";

	internal const string Can_not_issue_cookie_or_redirect = "Can_not_issue_cookie_or_redirect";

	internal const string Profile_default_provider_not_found = "Profile_default_provider_not_found";

	internal const string Value_must_be_boolean = "Value_must_be_boolean";

	internal const string Value_must_be_positive_integer = "Value_must_be_positive_integer";

	internal const string Value_must_be_non_negative_integer = "Value_must_be_non_negative_integer";

	internal const string Value_too_big = "Value_too_big";

	internal const string Profile_name_can_not_be_empty = "Profile_name_can_not_be_empty";

	internal const string Profile_name_can_not_contain_period = "Profile_name_can_not_contain_period";

	internal const string Provider_user_not_found = "Provider_user_not_found";

	internal const string Provider_role_not_found = "Provider_role_not_found";

	internal const string Provider_unknown_failure = "Provider_unknown_failure";

	internal const string Provider_role_already_exists = "Provider_role_already_exists";

	internal const string Profile_default_provider_not_specified = "Profile_default_provider_not_specified";

	internal const string API_not_supported_at_this_level = "API_not_supported_at_this_level";

	internal const string Profile_bad_name = "Profile_bad_name";

	internal const string Profile_bad_group = "Profile_bad_group";

	internal const string Def_membership_provider_not_specified = "Def_membership_provider_not_specified";

	internal const string Def_membership_provider_not_found = "Def_membership_provider_not_found";

	internal const string Provider_Error = "Provider_Error";

	internal const string Roles_feature_not_enabled = "Roles_feature_not_enabled";

	internal const string Def_role_provider_not_specified = "Def_role_provider_not_specified";

	internal const string Def_role_provider_not_found = "Def_role_provider_not_found";

	internal const string Membership_PasswordRetrieval_not_supported = "Membership_PasswordRetrieval_not_supported";

	internal const string Membership_UserNotFound = "Membership_UserNotFound";

	internal const string Membership_WrongPassword = "Membership_WrongPassword";

	internal const string Membership_WrongAnswer = "Membership_WrongAnswer";

	internal const string Membership_InvalidPassword = "Membership_InvalidPassword";

	internal const string Membership_InvalidQuestion = "Membership_InvalidQuestion";

	internal const string Membership_InvalidAnswer = "Membership_InvalidAnswer";

	internal const string Membership_InvalidUserName = "Membership_InvalidUserName";

	internal const string Membership_InvalidEmail = "Membership_InvalidEmail";

	internal const string Membership_DuplicateUserName = "Membership_DuplicateUserName";

	internal const string Membership_DuplicateEmail = "Membership_DuplicateEmail";

	internal const string Membership_UserRejected = "Membership_UserRejected";

	internal const string Membership_InvalidProviderUserKey = "Membership_InvalidProviderUserKey";

	internal const string Membership_DuplicateProviderUserKey = "Membership_DuplicateProviderUserKey";

	internal const string Membership_AccountLockOut = "Membership_AccountLockOut";

	internal const string Membership_Custom_Password_Validation_Failure = "Membership_Custom_Password_Validation_Failure";

	internal const string MinRequiredNonalphanumericCharacters_can_not_be_more_than_MinRequiredPasswordLength = "MinRequiredNonalphanumericCharacters_can_not_be_more_than_MinRequiredPasswordLength";

	internal const string ADMembership_Description = "ADMembership_Description";

	internal const string ADMembership_InvalidConnectionProtection = "ADMembership_InvalidConnectionProtection";

	internal const string ADMembership_Connection_username_must_not_be_empty = "ADMembership_Connection_username_must_not_be_empty";

	internal const string ADMembership_Connection_password_must_not_be_empty = "ADMembership_Connection_password_must_not_be_empty";

	internal const string ADMembership_Schema_mappings_must_not_be_empty = "ADMembership_Schema_mappings_must_not_be_empty";

	internal const string ADMembership_Username_and_password_reqd = "ADMembership_Username_and_password_reqd";

	internal const string ADMembership_PasswordReset_without_question_not_supported = "ADMembership_PasswordReset_without_question_not_supported";

	internal const string ADMembership_PasswordQuestionAnswerMapping_not_specified = "ADMembership_PasswordQuestionAnswerMapping_not_specified";

	internal const string ADMembership_Provider_not_initialized = "ADMembership_Provider_not_initialized";

	internal const string ADMembership_PasswordQ_not_supported = "ADMembership_PasswordQ_not_supported";

	internal const string ADMembership_PasswordA_not_supported = "ADMembership_PasswordA_not_supported";

	internal const string ADMembership_PasswordRetrieval_not_supported_AD = "ADMembership_PasswordRetrieval_not_supported_AD";

	internal const string ADMembership_Username_mapping_invalid = "ADMembership_Username_mapping_invalid";

	internal const string ADMembership_Username_mapping_invalid_ADAM = "ADMembership_Username_mapping_invalid_ADAM";

	internal const string ADMembership_Wrong_syntax = "ADMembership_Wrong_syntax";

	internal const string ADMembership_MappedAttribute_does_not_exist = "ADMembership_MappedAttribute_does_not_exist";

	internal const string ADMembership_MappedAttribute_does_not_exist_on_user = "ADMembership_MappedAttribute_does_not_exist_on_user";

	internal const string ADMembership_OnlyLdap_supported = "ADMembership_OnlyLdap_supported";

	internal const string ADMembership_ServerlessADsPath_not_supported = "ADMembership_ServerlessADsPath_not_supported";

	internal const string ADMembership_Secure_connection_not_established = "ADMembership_Secure_connection_not_established";

	internal const string ADMembership_Ssl_connection_not_established = "ADMembership_Ssl_connection_not_established";

	internal const string ADMembership_DefContainer_not_specified = "ADMembership_DefContainer_not_specified";

	internal const string ADMembership_DefContainer_does_not_exist = "ADMembership_DefContainer_does_not_exist";

	internal const string ADMembership_Container_must_be_specified = "ADMembership_Container_must_be_specified";

	internal const string ADMembership_Valid_Targets = "ADMembership_Valid_Targets";

	internal const string ADMembership_OnlineUsers_not_supported = "ADMembership_OnlineUsers_not_supported";

	internal const string ADMembership_UserProperty_not_supported = "ADMembership_UserProperty_not_supported";

	internal const string ADMembership_Provider_SearchMethods_not_supported = "ADMembership_Provider_SearchMethods_not_supported";

	internal const string ADMembership_No_ADAM_Partition = "ADMembership_No_ADAM_Partition";

	internal const string ADMembership_Setting_UserId_not_supported = "ADMembership_Setting_UserId_not_supported";

	internal const string ADMembership_Default_Creds_not_supported = "ADMembership_Default_Creds_not_supported";

	internal const string ADMembership_Container_not_superior = "ADMembership_Container_not_superior";

	internal const string ADMembership_Container_does_not_exist = "ADMembership_Container_does_not_exist";

	internal const string ADMembership_Property_not_found_on_object = "ADMembership_Property_not_found_on_object";

	internal const string ADMembership_Property_not_found = "ADMembership_Property_not_found";

	internal const string ADMembership_BadPasswordAnswerMappings_not_specified = "ADMembership_BadPasswordAnswerMappings_not_specified";

	internal const string ADMembership_Unknown_Error = "ADMembership_Unknown_Error";

	internal const string ADMembership_GCPortsNotSupported = "ADMembership_GCPortsNotSupported";

	internal const string ADMembership_attribute_not_single_valued = "ADMembership_attribute_not_single_valued";

	internal const string ADMembership_mapping_not_unique = "ADMembership_mapping_not_unique";

	internal const string ADMembership_InvalidProviderUserKey = "ADMembership_InvalidProviderUserKey";

	internal const string ADMembership_unable_to_contact_domain = "ADMembership_unable_to_contact_domain";

	internal const string ADMembership_unable_to_set_password_port = "ADMembership_unable_to_set_password_port";

	internal const string ADMembership_invalid_path = "ADMembership_invalid_path";

	internal const string ADMembership_Setting_ApplicationName_not_supported = "ADMembership_Setting_ApplicationName_not_supported";

	internal const string ADMembership_Parameter_too_long = "ADMembership_Parameter_too_long";

	internal const string ADMembership_No_secure_conn_for_password = "ADMembership_No_secure_conn_for_password";

	internal const string ADMembership_Generated_password_not_complex = "ADMembership_Generated_password_not_complex";

	internal const string ADMembership_UPN_contains_backslash = "ADMembership_UPN_contains_backslash";

	internal const string Windows_Token_API_not_supported = "Windows_Token_API_not_supported";

	internal const string Parameter_can_not_contain_comma = "Parameter_can_not_contain_comma";

	internal const string Parameter_can_not_be_empty = "Parameter_can_not_be_empty";

	internal const string Parameter_too_long = "Parameter_too_long";

	internal const string Parameter_array_empty = "Parameter_array_empty";

	internal const string Parameter_collection_empty = "Parameter_collection_empty";

	internal const string Parameter_duplicate_array_element = "Parameter_duplicate_array_element";

	internal const string Membership_password_too_long = "Membership_password_too_long";

	internal const string Provider_this_user_not_found = "Provider_this_user_not_found";

	internal const string Provider_this_user_already_in_role = "Provider_this_user_already_in_role";

	internal const string Provider_this_user_already_not_in_role = "Provider_this_user_already_not_in_role";

	internal const string SaveAs_requires_rooted_path = "SaveAs_requires_rooted_path";

	internal const string Connection_name_not_specified = "Connection_name_not_specified";

	internal const string Connection_string_not_found = "Connection_string_not_found";

	internal const string AppSetting_not_found = "AppSetting_not_found";

	internal const string AppSetting_not_convertible = "AppSetting_not_convertible";

	internal const string Provider_must_implement_type = "Provider_must_implement_type";

	internal const string Feature_not_supported_at_this_level = "Feature_not_supported_at_this_level";

	internal const string Annoymous_id_module_not_enabled = "Annoymous_id_module_not_enabled";

	internal const string Anonymous_ClearAnonymousIdentifierNotSupported = "Anonymous_ClearAnonymousIdentifierNotSupported";

	internal const string Anonymous_id_too_long = "Anonymous_id_too_long";

	internal const string Anonymous_id_too_long_2 = "Anonymous_id_too_long_2";

	internal const string Profile_could_not_create_type = "Profile_could_not_create_type";

	internal const string DataAccessError_CanNotCreateDataDir_Title = "DataAccessError_CanNotCreateDataDir_Title";

	internal const string DataAccessError_CanNotCreateDataDir_Description = "DataAccessError_CanNotCreateDataDir_Description";

	internal const string DataAccessError_CanNotCreateDataDir_Description_2 = "DataAccessError_CanNotCreateDataDir_Description_2";

	internal const string DataAccessError_MiscSectionTitle = "DataAccessError_MiscSectionTitle";

	internal const string DataAccessError_MiscSection_1 = "DataAccessError_MiscSection_1";

	internal const string DataAccessError_MiscSection_2 = "DataAccessError_MiscSection_2";

	internal const string DataAccessError_MiscSection_2_CanNotCreateDataDir = "DataAccessError_MiscSection_2_CanNotCreateDataDir";

	internal const string DataAccessError_MiscSection_2_CanNotWriteToDBFile_a = "DataAccessError_MiscSection_2_CanNotWriteToDBFile_a";

	internal const string DataAccessError_MiscSection_2_CanNotWriteToDBFile_b = "DataAccessError_MiscSection_2_CanNotWriteToDBFile_b";

	internal const string DataAccessError_MiscSection_3 = "DataAccessError_MiscSection_3";

	internal const string DataAccessError_MiscSection_4 = "DataAccessError_MiscSection_4";

	internal const string DataAccessError_MiscSection_4_2 = "DataAccessError_MiscSection_4_2";

	internal const string DataAccessError_MiscSection_ClickAdd = "DataAccessError_MiscSection_ClickAdd";

	internal const string DataAccessError_MiscSection_ClickOK = "DataAccessError_MiscSection_ClickOK";

	internal const string DataAccessError_MiscSection_5 = "DataAccessError_MiscSection_5";

	internal const string SqlExpressError_CanNotWriteToDataDir_Title = "SqlExpressError_CanNotWriteToDataDir_Title";

	internal const string SqlExpressError_CanNotWriteToDbfFile_Title = "SqlExpressError_CanNotWriteToDbfFile_Title";

	internal const string SqlExpressError_CanNotWriteToDataDir_Description = "SqlExpressError_CanNotWriteToDataDir_Description";

	internal const string SqlExpressError_CanNotWriteToDbfFile_Description = "SqlExpressError_CanNotWriteToDbfFile_Description";

	internal const string SqlExpressError_CanNotWriteToDataDir_Description_2 = "SqlExpressError_CanNotWriteToDataDir_Description_2";

	internal const string SqlExpressError_CanNotWriteToDbfFile_Description_2 = "SqlExpressError_CanNotWriteToDbfFile_Description_2";

	internal const string SqlExpressError_Description_1 = "SqlExpressError_Description_1";

	internal const string Membership_password_length_incorrect = "Membership_password_length_incorrect";

	internal const string Membership_min_required_non_alphanumeric_characters_incorrect = "Membership_min_required_non_alphanumeric_characters_incorrect";

	internal const string Membership_more_than_one_user_with_email = "Membership_more_than_one_user_with_email";

	internal const string Password_too_short = "Password_too_short";

	internal const string Password_need_more_non_alpha_numeric_chars = "Password_need_more_non_alpha_numeric_chars";

	internal const string Password_does_not_match_regular_expression = "Password_does_not_match_regular_expression";

	internal const string Not_configured_to_support_password_resets = "Not_configured_to_support_password_resets";

	internal const string Property_not_serializable = "Property_not_serializable";

	internal const string Connection_not_secure_creating_secure_cookie = "Connection_not_secure_creating_secure_cookie";

	internal const string Profile_anonoymous_not_allowed_to_set_property = "Profile_anonoymous_not_allowed_to_set_property";

	internal const string AuthStore_Application_not_found = "AuthStore_Application_not_found";

	internal const string AuthStore_Scope_not_found = "AuthStore_Scope_not_found";

	internal const string AuthStoreNotInstalled_Title = "AuthStoreNotInstalled_Title";

	internal const string AuthStoreNotInstalled_Description = "AuthStoreNotInstalled_Description";

	internal const string AuthStore_policy_file_not_found = "AuthStore_policy_file_not_found";

	internal const string Wrong_profile_base_type = "Wrong_profile_base_type";

	internal const string Command_not_recognized = "Command_not_recognized";

	internal const string Configuration_for_path_not_found = "Configuration_for_path_not_found";

	internal const string Configuration_for_physical_path_not_found = "Configuration_for_physical_path_not_found";

	internal const string Configuration_for_machine_config_not_found = "Configuration_for_machine_config_not_found";

	internal const string Configuration_Section_not_found = "Configuration_Section_not_found";

	internal const string RSA_Key_Container_not_found = "RSA_Key_Container_not_found";

	internal const string RSA_Key_Container_access_denied = "RSA_Key_Container_access_denied";

	internal const string RSA_Key_Container_already_exists = "RSA_Key_Container_already_exists";

	internal const string SqlError_Connection_String = "SqlError_Connection_String";

	internal const string SqlExpress_MDF_File_Auto_Creation_MiscSectionTitle = "SqlExpress_MDF_File_Auto_Creation_MiscSectionTitle";

	internal const string SqlExpress_MDF_File_Auto_Creation = "SqlExpress_MDF_File_Auto_Creation";

	internal const string SqlExpress_MDF_File_Auto_Creation_1 = "SqlExpress_MDF_File_Auto_Creation_1";

	internal const string SqlExpress_MDF_File_Auto_Creation_2 = "SqlExpress_MDF_File_Auto_Creation_2";

	internal const string SqlExpress_MDF_File_Auto_Creation_3 = "SqlExpress_MDF_File_Auto_Creation_3";

	internal const string SqlExpress_MDF_File_Auto_Creation_4 = "SqlExpress_MDF_File_Auto_Creation_4";

	internal const string SqlExpress_file_not_found_in_connection_string = "SqlExpress_file_not_found_in_connection_string";

	internal const string SqlExpress_file_not_found = "SqlExpress_file_not_found";

	internal const string Invalid_value_for_sessionstate_stateConnectionString = "Invalid_value_for_sessionstate_stateConnectionString";

	internal const string No_database_allowed_in_sqlConnectionString = "No_database_allowed_in_sqlConnectionString";

	internal const string No_database_allowed_in_sql_partition_resolver_string = "No_database_allowed_in_sql_partition_resolver_string";

	internal const string Error_parsing_session_sqlConnectionString = "Error_parsing_session_sqlConnectionString";

	internal const string Error_parsing_sql_partition_resolver_string = "Error_parsing_sql_partition_resolver_string";

	internal const string Timeout_must_be_positive = "Timeout_must_be_positive";

	internal const string Cant_make_session_request = "Cant_make_session_request";

	internal const string Cant_make_session_request_partition_resolver = "Cant_make_session_request_partition_resolver";

	internal const string Need_v2_State_Server = "Need_v2_State_Server";

	internal const string Need_v2_State_Server_partition_resolver = "Need_v2_State_Server_partition_resolver";

	internal const string Cant_connect_sql_session_database = "Cant_connect_sql_session_database";

	internal const string Cant_connect_sql_session_database_partition_resolver = "Cant_connect_sql_session_database_partition_resolver";

	internal const string Login_failed_sql_session_database = "Login_failed_sql_session_database";

	internal const string Bad_partition_resolver_connection_string = "Bad_partition_resolver_connection_string";

	internal const string Bad_state_server_request = "Bad_state_server_request";

	internal const string Bad_state_server_request_partition_resolver = "Bad_state_server_request_partition_resolver";

	internal const string State_Server_detailed_error = "State_Server_detailed_error";

	internal const string State_Server_detailed_error_phase0 = "State_Server_detailed_error_phase0";

	internal const string State_Server_detailed_error_phase1 = "State_Server_detailed_error_phase1";

	internal const string State_Server_detailed_error_phase2 = "State_Server_detailed_error_phase2";

	internal const string State_Server_detailed_error_phase3 = "State_Server_detailed_error_phase3";

	internal const string Error_parsing_state_server_partition_resolver_string = "Error_parsing_state_server_partition_resolver_string";

	internal const string SessionIDManager_uninit = "SessionIDManager_uninit";

	internal const string SessionIDManager_InitializeRequest_not_called = "SessionIDManager_InitializeRequest_not_called";

	internal const string Cant_save_session_id_because_response_was_flushed = "Cant_save_session_id_because_response_was_flushed";

	internal const string Cant_save_session_id_because_id_is_invalid = "Cant_save_session_id_because_id_is_invalid";

	internal const string Cant_serialize_session_state = "Cant_serialize_session_state";

	internal const string Null_value_for_SessionStateItemCollection = "Null_value_for_SessionStateItemCollection";

	internal const string Session_id_too_long = "Session_id_too_long";

	internal const string Need_v2_SQL_Server = "Need_v2_SQL_Server";

	internal const string Need_v2_SQL_Server_partition_resolver = "Need_v2_SQL_Server_partition_resolver";

	internal const string Cant_have_multiple_session_module = "Cant_have_multiple_session_module";

	internal const string Missing_session_custom_provider = "Missing_session_custom_provider";

	internal const string Invalid_session_custom_provider = "Invalid_session_custom_provider";

	internal const string Invalid_session_state = "Invalid_session_state";

	internal const string Invalid_cache_based_session_timeout = "Invalid_cache_based_session_timeout";

	internal const string Cant_use_partition_resolve = "Cant_use_partition_resolve";

	internal const string Previous_Page_Not_Authorized = "Previous_Page_Not_Authorized";

	internal const string Empty_path_has_no_directory = "Empty_path_has_no_directory";

	internal const string Path_must_be_rooted = "Path_must_be_rooted";

	internal const string Cannot_exit_up_top_directory = "Cannot_exit_up_top_directory";

	internal const string Physical_path_not_allowed = "Physical_path_not_allowed";

	internal const string Invalid_vpath = "Invalid_vpath";

	internal const string Cannot_access_AspCompat = "Cannot_access_AspCompat";

	internal const string Apartment_component_not_allowed = "Apartment_component_not_allowed";

	internal const string Error_onpagestart = "Error_onpagestart";

	internal const string Cannot_execute_transacted_code = "Cannot_execute_transacted_code";

	internal const string Cannot_post_workitem = "Cannot_post_workitem";

	internal const string Cannot_call_ISAPI_functions = "Cannot_call_ISAPI_functions";

	internal const string Bad_attachment = "Bad_attachment";

	internal const string Wrong_SimpleWorkerRequest = "Wrong_SimpleWorkerRequest";

	internal const string Atio2BadString = "Atio2BadString";

	internal const string MakeMonthBadString = "MakeMonthBadString";

	internal const string UtilParseDateTimeBad = "UtilParseDateTimeBad";

	internal const string SmtpMail_not_supported_on_Win7_and_higher = "SmtpMail_not_supported_on_Win7_and_higher";

	internal const string Illegal_special_dir = "Illegal_special_dir";

	internal const string Precomp_stub_file = "Precomp_stub_file";

	internal const string Already_precomp = "Already_precomp";

	internal const string Cant_delete_dir = "Cant_delete_dir";

	internal const string Dir_not_empty = "Dir_not_empty";

	internal const string Dir_not_empty_not_precomp = "Dir_not_empty_not_precomp";

	internal const string Cant_update_precompiled_app = "Cant_update_precompiled_app";

	internal const string Too_early_for_webfile = "Too_early_for_webfile";

	internal const string Bar_dir_in_precompiled_app = "Bar_dir_in_precompiled_app";

	internal const string Assembly_already_loaded = "Assembly_already_loaded";

	internal const string Success_precompile = "Success_precompile";

	internal const string Profile_not_precomped = "Profile_not_precomped";

	internal const string Both_culture_and_language = "Both_culture_and_language";

	internal const string Inconsistent_language = "Inconsistent_language";

	internal const string GetGeneratedSourceFile_Directory_Only = "GetGeneratedSourceFile_Directory_Only";

	internal const string Duplicate_appinitialize = "Duplicate_appinitialize";

	internal const string Virtual_codedir = "Virtual_codedir";

	internal const string Unknown_buildprovider_extension = "Unknown_buildprovider_extension";

	internal const string Directory_progress = "Directory_progress";

	internal const string Bad_Base_Class_In_Code_File = "Bad_Base_Class_In_Code_File";

	internal const string Reference_assemblies_not_found = "Reference_assemblies_not_found";

	internal const string Higher_dependencies = "Higher_dependencies";

	internal const string Invalid_target_framework_version = "Invalid_target_framework_version";

	internal const string Invalid_lower_target_version = "Invalid_lower_target_version";

	internal const string Invalid_higher_target_version = "Invalid_higher_target_version";

	internal const string Compiler_version_20_35_required = "Compiler_version_20_35_required";

	internal const string Compiler_version_40_required = "Compiler_version_40_required";

	internal const string Assembly_not_found_in_profile = "Assembly_not_found_in_profile";

	internal const string Downlevel_requires_35 = "Downlevel_requires_35";

	internal const string Invalid_PreApplicationStartMethodAttribute_value = "Invalid_PreApplicationStartMethodAttribute_value";

	internal const string Method_can_only_be_called_during_pre_start_init = "Method_can_only_be_called_during_pre_start_init";

	internal const string Method_cannot_be_called_during_pre_start_init = "Method_cannot_be_called_during_pre_start_init";

	internal const string Pre_application_start_init_method_threw_exception = "Pre_application_start_init_method_threw_exception";

	internal const string Cant_use_default_items_and_filtered_collection = "Cant_use_default_items_and_filtered_collection";

	internal const string Children_not_supported_on_not_controls = "Children_not_supported_on_not_controls";

	internal const string Code_not_supported_on_not_controls = "Code_not_supported_on_not_controls";

	internal const string Code_not_allowed = "Code_not_allowed";

	internal const string Compilmode_not_allowed = "Compilmode_not_allowed";

	internal const string Include_not_allowed = "Include_not_allowed";

	internal const string Attrib_not_allowed = "Attrib_not_allowed";

	internal const string Directive_not_allowed = "Directive_not_allowed";

	internal const string Event_not_allowed = "Event_not_allowed";

	internal const string Literal_content_not_allowed = "Literal_content_not_allowed";

	internal const string Literal_content_not_match_property = "Literal_content_not_match_property";

	internal const string Too_many_controls = "Too_many_controls";

	internal const string Too_many_dependencies = "Too_many_dependencies";

	internal const string Too_many_direct_dependencies = "Too_many_direct_dependencies";

	internal const string Invalid_type = "Invalid_type";

	internal const string Assembly_not_compiled = "Assembly_not_compiled";

	internal const string Not_a_src_file = "Not_a_src_file";

	internal const string Ambiguous_type = "Ambiguous_type";

	internal const string Unsupported_filename = "Unsupported_filename";

	internal const string Cannot_convert_from_to = "Cannot_convert_from_to";

	internal const string Object_tag_must_have_id = "Object_tag_must_have_id";

	internal const string Invalid_scope = "Invalid_scope";

	internal const string Invalid_progid = "Invalid_progid";

	internal const string Invalid_clsid = "Invalid_clsid";

	internal const string Object_tag_must_have_class_classid_or_progid = "Object_tag_must_have_class_classid_or_progid";

	internal const string Session_not_enabled = "Session_not_enabled";

	internal const string Page_ControlState_ControlCannotBeNull = "Page_ControlState_ControlCannotBeNull";

	internal const string Page_theme_not_found = "Page_theme_not_found";

	internal const string Page_theme_invalid_name = "Page_theme_invalid_name";

	internal const string Page_theme_default_theme_already_defined = "Page_theme_default_theme_already_defined";

	internal const string Page_theme_skinID_already_defined = "Page_theme_skinID_already_defined";

	internal const string Page_theme_requires_page_header = "Page_theme_requires_page_header";

	internal const string Page_theme_only_controls_allowed = "Page_theme_only_controls_allowed";

	internal const string Page_theme_skin_file = "Page_theme_skin_file";

	internal const string Page_Title_Requires_Head = "Page_Title_Requires_Head";

	internal const string Page_Description_Requires_Head = "Page_Description_Requires_Head";

	internal const string Page_Keywords_Requires_Head = "Page_Keywords_Requires_Head";

	internal const string DataBoundLiterals_cant_bind = "DataBoundLiterals_cant_bind";

	internal const string TwoWayBinding_requires_ID = "TwoWayBinding_requires_ID";

	internal const string NoCompileBinding_requires_ID = "NoCompileBinding_requires_ID";

	internal const string BadlyFormattedBind = "BadlyFormattedBind";

	internal const string BadlyFormattedBindItem = "BadlyFormattedBindItem";

	internal const string Property_readonly = "Property_readonly";

	internal const string Property_theme_disabled = "Property_theme_disabled";

	internal const string Type_theme_disabled = "Type_theme_disabled";

	internal const string Collection_readonly_Codeblocks = "Collection_readonly_Codeblocks";

	internal const string Parent_collections_readonly = "Parent_collections_readonly";

	internal const string Property_Not_Persistable = "Property_Not_Persistable";

	internal const string Property_Not_Supported = "Property_Not_Supported";

	internal const string Property_Not_ClsCompliant = "Property_Not_ClsCompliant";

	internal const string Property_Set_Not_Supported = "Property_Set_Not_Supported";

	internal const string ControlBuilder_InvalidLocalizeValue = "ControlBuilder_InvalidLocalizeValue";

	internal const string meta_localize_error = "meta_localize_error";

	internal const string meta_reskey_notallowed = "meta_reskey_notallowed";

	internal const string meta_localize_notallowed = "meta_localize_notallowed";

	internal const string Invalid_enum_value = "Invalid_enum_value";

	internal const string Type_not_creatable_from_string = "Type_not_creatable_from_string";

	internal const string Invalid_collection_item_type = "Invalid_collection_item_type";

	internal const string Invalid_template_container = "Invalid_template_container";

	internal const string Event_handler_cant_be_empty = "Event_handler_cant_be_empty";

	internal const string Events_cant_be_filtered = "Events_cant_be_filtered";

	internal const string Type_doesnt_have_property = "Type_doesnt_have_property";

	internal const string Property_doesnt_have_property = "Property_doesnt_have_property";

	internal const string MasterPage_Multiple_content = "MasterPage_Multiple_content";

	internal const string MasterPage_doesnt_have_contentplaceholder = "MasterPage_doesnt_have_contentplaceholder";

	internal const string MasterPage_MasterPageFile = "MasterPage_MasterPageFile";

	internal const string MasterPage_MasterPage = "MasterPage_MasterPage";

	internal const string MasterPage_Circular_Master_Not_Allowed = "MasterPage_Circular_Master_Not_Allowed";

	internal const string MasterPage_Cannot_ApplyTo_ReadOnly_Collection = "MasterPage_Cannot_ApplyTo_ReadOnly_Collection";

	internal const string Only_Content_supported_on_content_page = "Only_Content_supported_on_content_page";

	internal const string Content_allowed_in_top_level_only = "Content_allowed_in_top_level_only";

	internal const string Content_only_allowed_in_content_page = "Content_only_allowed_in_content_page";

	internal const string Content_only_one_contentPlaceHolderID_allowed = "Content_only_one_contentPlaceHolderID_allowed";

	internal const string Invalid_master_base = "Invalid_master_base";

	internal const string Invalid_typeless_reference = "Invalid_typeless_reference";

	internal const string Bad_masterPage_ext = "Bad_masterPage_ext";

	internal const string Illegal_Device = "Illegal_Device";

	internal const string Illegal_Resource_Builder = "Illegal_Resource_Builder";

	internal const string Too_many_filters = "Too_many_filters";

	internal const string Device_unsupported_in_directive = "Device_unsupported_in_directive";

	internal const string Cannot_add_value_not_collection = "Cannot_add_value_not_collection";

	internal const string ControlBuilder_CollectionHasNoAddMethod = "ControlBuilder_CollectionHasNoAddMethod";

	internal const string Cannot_set_property = "Cannot_set_property";

	internal const string Cannot_set_recursive_skin = "Cannot_set_recursive_skin";

	internal const string Cannot_evaluate_expression = "Cannot_evaluate_expression";

	internal const string Cannot_init = "Cannot_init";

	internal const string Unexpected_Directory = "Unexpected_Directory";

	internal const string Circular_include = "Circular_include";

	internal const string Unexpected_eof_looking_for_tag = "Unexpected_eof_looking_for_tag";

	internal const string Invalid_app_file_content = "Invalid_app_file_content";

	internal const string Invalid_use_of_config_uc = "Invalid_use_of_config_uc";

	internal const string Page_scope_in_global_asax = "Page_scope_in_global_asax";

	internal const string App_session_only_valid_in_global_asax = "App_session_only_valid_in_global_asax";

	internal const string Multiple_forms_not_allowed = "Multiple_forms_not_allowed";

	internal const string Postback_ctrl_not_found = "Postback_ctrl_not_found";

	internal const string Ctrl_not_data_handler = "Ctrl_not_data_handler";

	internal const string Transfer_not_allowed_in_callback = "Transfer_not_allowed_in_callback";

	internal const string Redirect_not_allowed_in_callback = "Redirect_not_allowed_in_callback";

	internal const string Script_tag_without_src_must_have_content = "Script_tag_without_src_must_have_content";

	internal const string Unknown_server_tag = "Unknown_server_tag";

	internal const string Ambiguous_server_tag = "Ambiguous_server_tag";

	internal const string Invalid_type_for_input_tag = "Invalid_type_for_input_tag";

	internal const string Control_type_not_allowed = "Control_type_not_allowed";

	internal const string Base_type_not_allowed = "Base_type_not_allowed";

	internal const string Reference_not_allowed = "Reference_not_allowed";

	internal const string Id_already_used = "Id_already_used";

	internal const string Duplicate_id_used = "Duplicate_id_used";

	internal const string Only_one_directive_allowed = "Only_one_directive_allowed";

	internal const string Invalid_res_expr = "Invalid_res_expr";

	internal const string Res_not_found = "Res_not_found";

	internal const string Res_not_found_with_class_and_key = "Res_not_found_with_class_and_key";

	internal const string Invalid_cache_settings_location = "Invalid_cache_settings_location";

	internal const string Registered_async_tasks_remain = "Registered_async_tasks_remain";

	internal const string Async_tasks_wrong_thread = "Async_tasks_wrong_thread";

	internal const string Async_task_timed_out = "Async_task_timed_out";

	internal const string ClientScriptManager_RegisterForEventValidation_Too_Early = "ClientScriptManager_RegisterForEventValidation_Too_Early";

	internal const string ClientScriptManager_InvalidPostBackArgument = "ClientScriptManager_InvalidPostBackArgument";

	internal const string ClientScriptManager_JqueryNotRegistered = "ClientScriptManager_JqueryNotRegistered";

	internal const string DesignTimeTemplateParser_ErrorParsingTheme = "DesignTimeTemplateParser_ErrorParsingTheme";

	internal const string Duplicate_registered_tag = "Duplicate_registered_tag";

	internal const string Empty_attribute = "Empty_attribute";

	internal const string Space_attribute = "Space_attribute";

	internal const string Empty_expression = "Empty_expression";

	internal const string ControlBuilder_DatabindingRequiresEvent = "ControlBuilder_DatabindingRequiresEvent";

	internal const string ControlBuilder_TwoWayBindingNonProperty = "ControlBuilder_TwoWayBindingNonProperty";

	internal const string ControlBuilder_CannotHaveMultipleBoundEntries = "ControlBuilder_CannotHaveMultipleBoundEntries";

	internal const string ControlBuilder_ExpressionsNotAllowedInThemes = "ControlBuilder_ExpressionsNotAllowedInThemes";

	internal const string FilteredAttributeDictionary_ArgumentMustBeString = "FilteredAttributeDictionary_ArgumentMustBeString";

	internal const string HotSpotCollection_InvalidType = "HotSpotCollection_InvalidType";

	internal const string HotSpotCollection_InvalidTypeIndex = "HotSpotCollection_InvalidTypeIndex";

	internal const string Invalid_attribute_value = "Invalid_attribute_value";

	internal const string Invalid_boolean_attribute = "Invalid_boolean_attribute";

	internal const string Invalid_integer_attribute = "Invalid_integer_attribute";

	internal const string Invalid_nonnegative_integer_attribute = "Invalid_nonnegative_integer_attribute";

	internal const string Invalid_positive_integer_attribute = "Invalid_positive_integer_attribute";

	internal const string Invalid_non_zero_hexadecimal_attribute = "Invalid_non_zero_hexadecimal_attribute";

	internal const string Invalid_hash_algorithm_type = "Invalid_hash_algorithm_type";

	internal const string Invalid_enum_attribute = "Invalid_enum_attribute";

	internal const string Invalid_culture_attribute = "Invalid_culture_attribute";

	internal const string Invalid_temp_directory = "Invalid_temp_directory";

	internal const string Invalid_reference_directive = "Invalid_reference_directive";

	internal const string Invalid_reference_directive_attrib = "Invalid_reference_directive_attrib";

	internal const string Invalid_typeNameOrVirtualPath_directive = "Invalid_typeNameOrVirtualPath_directive";

	internal const string Invalid_tagprefix_entry = "Invalid_tagprefix_entry";

	internal const string Mapped_type_must_inherit = "Mapped_type_must_inherit";

	internal const string Missing_required_attribute = "Missing_required_attribute";

	internal const string Missing_required_attributes = "Missing_required_attributes";

	internal const string Attr_not_supported_in_directive = "Attr_not_supported_in_directive";

	internal const string Attr_not_supported_in_ucdirective = "Attr_not_supported_in_ucdirective";

	internal const string Attr_not_supported_in_pagedirective = "Attr_not_supported_in_pagedirective";

	internal const string Invalid_attr = "Invalid_attr";

	internal const string Attrib_parse_error = "Attrib_parse_error";

	internal const string Missing_attr = "Missing_attr";

	internal const string Missing_output_cache_attr = "Missing_output_cache_attr";

	internal const string Missing_varybyparam_attr = "Missing_varybyparam_attr";

	internal const string Missing_directive = "Missing_directive";

	internal const string Unknown_directive = "Unknown_directive";

	internal const string Malformed_server_tag = "Malformed_server_tag";

	internal const string Malformed_server_block = "Malformed_server_block";

	internal const string Server_tags_cant_contain_percent_constructs = "Server_tags_cant_contain_percent_constructs";

	internal const string Include_not_allowed_in_server_script_tag = "Include_not_allowed_in_server_script_tag";

	internal const string Incompatible_with_get_bufferless_input_stream = "Incompatible_with_get_bufferless_input_stream";

	internal const string Incompatible_with_get_buffered_input_stream = "Incompatible_with_get_buffered_input_stream";

	internal const string Incompatible_with_input_stream = "Incompatible_with_input_stream";

	internal const string Invalid_operation_with_get_buffered_input_stream = "Invalid_operation_with_get_buffered_input_stream";

	internal const string Only_file_virtual_supported_on_server_include = "Only_file_virtual_supported_on_server_include";

	internal const string Runat_can_only_be_server = "Runat_can_only_be_server";

	internal const string Invalid_identifier = "Invalid_identifier";

	internal const string Invalid_resourcekey = "Invalid_resourcekey";

	internal const string ControlBuilder_IDMustUseAttribute = "ControlBuilder_IDMustUseAttribute";

	internal const string ControlBuilder_CannotHaveComplexString = "ControlBuilder_CannotHaveComplexString";

	internal const string ControlBuilder_ParseTimeDataNotAvailable = "ControlBuilder_ParseTimeDataNotAvailable";

	internal const string Duplicate_attr_in_directive = "Duplicate_attr_in_directive";

	internal const string Duplicate_attr_in_tag = "Duplicate_attr_in_tag";

	internal const string Non_existent_base_type = "Non_existent_base_type";

	internal const string Invalid_type_to_inherit_from = "Invalid_type_to_inherit_from";

	internal const string Invalid_type_to_implement = "Invalid_type_to_implement";

	internal const string Error_page_not_supported_when_buffering_off = "Error_page_not_supported_when_buffering_off";

	internal const string Enablesessionstate_must_be_true_false_or_readonly = "Enablesessionstate_must_be_true_false_or_readonly";

	internal const string Attributes_mutually_exclusive = "Attributes_mutually_exclusive";

	internal const string Async_and_aspcompat = "Async_and_aspcompat";

	internal const string Async_and_transaction = "Async_and_transaction";

	internal const string Async_required = "Async_required";

	internal const string Async_addhandler_too_late = "Async_addhandler_too_late";

	internal const string Async_operation_disabled = "Async_operation_disabled";

	internal const string Async_operation_pending = "Async_operation_pending";

	internal const string Async_null_asyncresult = "Async_null_asyncresult";

	internal const string Async_operation_cannot_be_started = "Async_operation_cannot_be_started";

	internal const string Async_operation_cannot_be_pending = "Async_operation_cannot_be_pending";

	internal const string Server_execute_blocked_on_async_handler = "Server_execute_blocked_on_async_handler";

	internal const string Mixed_lang_not_supported = "Mixed_lang_not_supported";

	internal const string Inconsistent_CodeFile_Language = "Inconsistent_CodeFile_Language";

	internal const string Codefile_without_inherits = "Codefile_without_inherits";

	internal const string CodeFileBaseClass_Without_Codefile = "CodeFileBaseClass_Without_Codefile";

	internal const string Invalid_lang = "Invalid_lang";

	internal const string Invalid_lang_extension = "Invalid_lang_extension";

	internal const string Cant_use_nocompile_uc = "Cant_use_nocompile_uc";

	internal const string Invalid_CodeSubDirectory_Not_Exist = "Invalid_CodeSubDirectory_Not_Exist";

	internal const string Invalid_CodeSubDirectory = "Invalid_CodeSubDirectory";

	internal const string Reserved_AssemblyName = "Reserved_AssemblyName";

	internal const string Empty_extension = "Empty_extension";

	internal const string Base_class_field_with_type_different_from_type_of_control = "Base_class_field_with_type_different_from_type_of_control";

	internal const string ControlSkin_cannot_contain_controls = "ControlSkin_cannot_contain_controls";

	internal const string Inner_Content_not_literal = "Inner_Content_not_literal";

	internal const string Invalid_client_target = "Invalid_client_target";

	internal const string Empty_file_name = "Empty_file_name";

	internal const string SetStyleSheetThemeCannotBeSet = "SetStyleSheetThemeCannotBeSet";

	internal const string PropertySetBeforePageEvent = "PropertySetBeforePageEvent";

	internal const string PropertySetBeforeStyleSheetApplied = "PropertySetBeforeStyleSheetApplied";

	internal const string PropertySetBeforePreInitOrAddToControls = "PropertySetBeforePreInitOrAddToControls";

	internal const string PropertySetAfterFrameworkInitialize = "PropertySetAfterFrameworkInitialize";

	internal const string StyleSheetAreadyAppliedOnControl = "StyleSheetAreadyAppliedOnControl";

	internal const string Control_CannotOwnSelf = "Control_CannotOwnSelf";

	internal const string AdRotator_cant_open_file = "AdRotator_cant_open_file";

	internal const string AdRotator_cant_open_file_no_permission = "AdRotator_cant_open_file_no_permission";

	internal const string AdRotator_parse_error = "AdRotator_parse_error";

	internal const string AdRotator_no_advertisements = "AdRotator_no_advertisements";

	internal const string AdRotator_only_one_datasource = "AdRotator_only_one_datasource";

	internal const string AdRotator_invalid_integer_format = "AdRotator_invalid_integer_format";

	internal const string AdRotator_expect_records_with_advertisement_properties = "AdRotator_expect_records_with_advertisement_properties";

	internal const string Validator_control_blank = "Validator_control_blank";

	internal const string Validator_control_not_found = "Validator_control_not_found";

	internal const string Validator_bad_compare_control = "Validator_bad_compare_control";

	internal const string Validator_bad_control_type = "Validator_bad_control_type";

	internal const string Validator_value_bad_type = "Validator_value_bad_type";

	internal const string Validator_range_overalap = "Validator_range_overalap";

	internal const string Validator_bad_regex = "Validator_bad_regex";

	internal const string ValSummary_error_message_1 = "ValSummary_error_message_1";

	internal const string ValSummary_error_message_2 = "ValSummary_error_message_2";

	internal const string ViewState_MissingViewStateField = "ViewState_MissingViewStateField";

	internal const string ViewState_InvalidViewState = "ViewState_InvalidViewState";

	internal const string ViewState_InvalidViewStatePlus = "ViewState_InvalidViewStatePlus";

	internal const string ClientDisconnected = "ClientDisconnected";

	internal const string HttpBufferlessInputStream_ClientDisconnected = "HttpBufferlessInputStream_ClientDisconnected";

	internal const string ViewState_ClientDisconnected = "ViewState_ClientDisconnected";

	internal const string ViewState_AuthenticationFailed = "ViewState_AuthenticationFailed";

	internal const string Control_does_not_allow_children = "Control_does_not_allow_children";

	internal const string DataBinder_Prop_Not_Found = "DataBinder_Prop_Not_Found";

	internal const string DataBinder_Invalid_Indexed_Expr = "DataBinder_Invalid_Indexed_Expr";

	internal const string DataBinder_No_Indexed_Accessor = "DataBinder_No_Indexed_Accessor";

	internal const string XPathBinder_MustBeIXPathNavigable = "XPathBinder_MustBeIXPathNavigable";

	internal const string XPathBinder_MustHaveXmlNodes = "XPathBinder_MustHaveXmlNodes";

	internal const string Field_Not_Found = "Field_Not_Found";

	internal const string DataItem_Not_Found = "DataItem_Not_Found";

	internal const string DataGrid_Missing_VirtualItemCount = "DataGrid_Missing_VirtualItemCount";

	internal const string DataGrid_NoAutoGenColumns = "DataGrid_NoAutoGenColumns";

	internal const string GridView_Missing_VirtualItemCount = "GridView_Missing_VirtualItemCount";

	internal const string GridView_NoAutoGenFields = "GridView_NoAutoGenFields";

	internal const string GridView_DataSourceReturnedNullView = "GridView_DataSourceReturnedNullView";

	internal const string GridView_UnhandledEvent = "GridView_UnhandledEvent";

	internal const string GridView_MustBeParented = "GridView_MustBeParented";

	internal const string GridView_DataKeyNamesMustBeSpecified = "GridView_DataKeyNamesMustBeSpecified";

	internal const string GridView_PersistedSelectionRequiresDataKeysNames = "GridView_PersistedSelectionRequiresDataKeysNames";

	internal const string DetailsView_NoAutoGenFields = "DetailsView_NoAutoGenFields";

	internal const string DetailsView_UnhandledEvent = "DetailsView_UnhandledEvent";

	internal const string DetailsView_DataSourceMustBeCollection = "DetailsView_DataSourceMustBeCollection";

	internal const string DetailsView_MustBeParented = "DetailsView_MustBeParented";

	internal const string FileUpload_AllowMultiple = "FileUpload_AllowMultiple";

	internal const string FileUpload_StreamNotSeekable = "FileUpload_StreamNotSeekable";

	internal const string FileUpload_StreamTooLong = "FileUpload_StreamTooLong";

	internal const string FileUpload_StreamLengthNotReached = "FileUpload_StreamLengthNotReached";

	internal const string FormView_UnhandledEvent = "FormView_UnhandledEvent";

	internal const string FormView_DataSourceMustBeCollection = "FormView_DataSourceMustBeCollection";

	internal const string DetailsViewFormView_ControlMustBeInEditMode = "DetailsViewFormView_ControlMustBeInEditMode";

	internal const string DetailsViewFormView_ControlMustBeInInsertMode = "DetailsViewFormView_ControlMustBeInInsertMode";

	internal const string DataBoundControl_InvalidDataPropertyChange = "DataBoundControl_InvalidDataPropertyChange";

	internal const string DataBoundControl_NullView = "DataBoundControl_NullView";

	internal const string DataBoundControl_InvalidDataSourceType = "DataBoundControl_InvalidDataSourceType";

	internal const string DataBoundControl_DataSourceDoesntSupportPaging = "DataBoundControl_DataSourceDoesntSupportPaging";

	internal const string DataBoundControl_CallingDataMethods = "DataBoundControl_CallingDataMethods";

	internal const string DataBoundControl_NeedICollectionOrTotalRowCount = "DataBoundControl_NeedICollectionOrTotalRowCount";

	internal const string DataBoundControlHelper_NoNamingContainer = "DataBoundControlHelper_NoNamingContainer";

	internal const string HierarchicalDataBoundControl_InvalidDataSource = "HierarchicalDataBoundControl_InvalidDataSource";

	internal const string DataBoundControl_OnCreatingModelDataSource = "DataBoundControl_OnCreatingModelDataSource";

	internal const string HierarchicalDataControl_ViewNotFound = "HierarchicalDataControl_ViewNotFound";

	internal const string HierarchicalDataControl_DataSourceIDMustBeHierarchicalDataControl = "HierarchicalDataControl_DataSourceIDMustBeHierarchicalDataControl";

	internal const string HierarchicalDataControl_DataSourceDoesntExist = "HierarchicalDataControl_DataSourceDoesntExist";

	internal const string DataControl_ViewNotFound = "DataControl_ViewNotFound";

	internal const string DataControl_DataSourceIDMustBeDataControl = "DataControl_DataSourceIDMustBeDataControl";

	internal const string DataControl_DataSourceDoesntExist = "DataControl_DataSourceDoesntExist";

	internal const string DataControl_MultipleDataSources = "DataControl_MultipleDataSources";

	internal const string DataControl_ItemType_MultipleDataSources = "DataControl_ItemType_MultipleDataSources";

	internal const string DataControlField_NoContainer = "DataControlField_NoContainer";

	internal const string DataControlField_CallbacksNotSupported = "DataControlField_CallbacksNotSupported";

	internal const string DataControlFieldCollection_InvalidType = "DataControlFieldCollection_InvalidType";

	internal const string DataControlFieldCollection_InvalidTypeIndex = "DataControlFieldCollection_InvalidTypeIndex";

	internal const string BoundField_WrongControlType = "BoundField_WrongControlType";

	internal const string CheckBoxField_WrongControlType = "CheckBoxField_WrongControlType";

	internal const string CheckBoxField_CouldntParseAsBoolean = "CheckBoxField_CouldntParseAsBoolean";

	internal const string CheckBoxField_NotSupported = "CheckBoxField_NotSupported";

	internal const string CommandField_CallbacksNotSupported = "CommandField_CallbacksNotSupported";

	internal const string ImageField_WrongControlType = "ImageField_WrongControlType";

	internal const string TemplateField_CallbacksNotSupported = "TemplateField_CallbacksNotSupported";

	internal const string PagedDataSource_Cannot_Get_Count = "PagedDataSource_Cannot_Get_Count";

	internal const string Cannot_Have_Children_Of_Type = "Cannot_Have_Children_Of_Type";

	internal const string Control_Cannot_Databind = "Control_Cannot_Databind";

	internal const string InnerHtml_not_supported = "InnerHtml_not_supported";

	internal const string InnerText_not_supported = "InnerText_not_supported";

	internal const string ListControl_SelectionOutOfRange = "ListControl_SelectionOutOfRange";

	internal const string ListControl_RenderWhenDataEmptyNotSupportedWithTableLayout = "ListControl_RenderWhenDataEmptyNotSupportedWithTableLayout";

	internal const string ListControl_RenderWhenDataEmpty = "ListControl_RenderWhenDataEmpty";

	internal const string BulletedList_SelectionNotSupported = "BulletedList_SelectionNotSupported";

	internal const string BulletedList_TextNotSupported = "BulletedList_TextNotSupported";

	internal const string CannotUseParentPostBackWhenValidating = "CannotUseParentPostBackWhenValidating";

	internal const string CannotSetValidationOnDataControlButtons = "CannotSetValidationOnDataControlButtons";

	internal const string CannotSetValidationOnPagerButtons = "CannotSetValidationOnPagerButtons";

	internal const string Invalid_DataSource_Type = "Invalid_DataSource_Type";

	internal const string Invalid_CurrentPageIndex = "Invalid_CurrentPageIndex";

	internal const string ListSource_Without_DataMembers = "ListSource_Without_DataMembers";

	internal const string ListSource_Missing_DataMember = "ListSource_Missing_DataMember";

	internal const string Enumerator_MoveNext_Not_Called = "Enumerator_MoveNext_Not_Called";

	internal const string Sample_Databound_Text = "Sample_Databound_Text";

	internal const string Resource_problem = "Resource_problem";

	internal const string Duplicate_Resource_File = "Duplicate_Resource_File";

	internal const string Property_Had_Malformed_Url = "Property_Had_Malformed_Url";

	internal const string TypeResService_Needed = "TypeResService_Needed";

	internal const string DataList_TemplateTableNotFound = "DataList_TemplateTableNotFound";

	internal const string DataList_DataKeyFieldMustBeSpecified = "DataList_DataKeyFieldMustBeSpecified";

	internal const string DataList_LayoutNotSupported = "DataList_LayoutNotSupported";

	internal const string EnumAttributeInvalidString = "EnumAttributeInvalidString";

	internal const string UnitParseNumericPart = "UnitParseNumericPart";

	internal const string UnitParseNoDigits = "UnitParseNoDigits";

	internal const string IsValid_Cant_Be_Called = "IsValid_Cant_Be_Called";

	internal const string Invalid_HtmlTextWriter = "Invalid_HtmlTextWriter";

	internal const string Form_Needs_Page = "Form_Needs_Page";

	internal const string InvalidDefaultAutoFieldGenerator = "InvalidDefaultAutoFieldGenerator";

	internal const string HtmlForm_OnlyIButtonControlCanBeDefaultButton = "HtmlForm_OnlyIButtonControlCanBeDefaultButton";

	internal const string Head_Needs_Page = "Head_Needs_Page";

	internal const string HtmlHead_StyleAlreadyRegistered = "HtmlHead_StyleAlreadyRegistered";

	internal const string HtmlHead_OnlyOneHeadAllowed = "HtmlHead_OnlyOneHeadAllowed";

	internal const string HtmlHead_OnlyOneTitleAllowed = "HtmlHead_OnlyOneTitleAllowed";

	internal const string Style_RegisteredStylesAreReadOnly = "Style_RegisteredStylesAreReadOnly";

	internal const string Style_InvalidBorderWidth = "Style_InvalidBorderWidth";

	internal const string Style_InvalidWidth = "Style_InvalidWidth";

	internal const string Style_InvalidHeight = "Style_InvalidHeight";

	internal const string Cant_Multiselect_In_Single_Mode = "Cant_Multiselect_In_Single_Mode";

	internal const string Cant_Multiselect = "Cant_Multiselect";

	internal const string HtmlSelect_Cant_Multiselect_In_Single_Mode = "HtmlSelect_Cant_Multiselect_In_Single_Mode";

	internal const string Controls_Cant_Change_Between_Posts = "Controls_Cant_Change_Between_Posts";

	internal const string Value_Set_Not_Supported = "Value_Set_Not_Supported";

	internal const string SiteMap_feature_disabled = "SiteMap_feature_disabled";

	internal const string SiteMapNode_readonly = "SiteMapNode_readonly";

	internal const string SiteMapNodeCollection_Invalid_Type = "SiteMapNodeCollection_Invalid_Type";

	internal const string SiteMapProvider_Circular_Provider = "SiteMapProvider_Circular_Provider";

	internal const string SiteMapProvider_Invalid_RootNode = "SiteMapProvider_Invalid_RootNode";

	internal const string SiteMapProvider_cannot_remove_root_node = "SiteMapProvider_cannot_remove_root_node";

	internal const string XmlSiteMapProvider_cannot_add_node = "XmlSiteMapProvider_cannot_add_node";

	internal const string XmlSiteMapProvider_invalid_resource_key = "XmlSiteMapProvider_invalid_resource_key";

	internal const string XmlSiteMapProvider_resourceKey_cannot_be_empty = "XmlSiteMapProvider_resourceKey_cannot_be_empty";

	internal const string XmlSiteMapProvider_cannot_find_provider = "XmlSiteMapProvider_cannot_find_provider";

	internal const string XmlSiteMapProvider_cannot_remove_node = "XmlSiteMapProvider_cannot_remove_node";

	internal const string XmlSiteMapProvider_missing_siteMapFile = "XmlSiteMapProvider_missing_siteMapFile";

	internal const string XmlSiteMapProvider_Description = "XmlSiteMapProvider_Description";

	internal const string XmlSiteMapProvider_Not_Initialized = "XmlSiteMapProvider_Not_Initialized";

	internal const string XmlSiteMapProvider_Cannot_Be_Inited_Twice = "XmlSiteMapProvider_Cannot_Be_Inited_Twice";

	internal const string XmlSiteMapProvider_Top_Element_Must_Be_SiteMap = "XmlSiteMapProvider_Top_Element_Must_Be_SiteMap";

	internal const string XmlSiteMapProvider_Only_One_SiteMapNode_Required_At_Top = "XmlSiteMapProvider_Only_One_SiteMapNode_Required_At_Top";

	internal const string XmlSiteMapProvider_Only_SiteMapNode_Allowed = "XmlSiteMapProvider_Only_SiteMapNode_Allowed";

	internal const string XmlSiteMapProvider_invalid_sitemapnode_returned = "XmlSiteMapProvider_invalid_sitemapnode_returned";

	internal const string XmlSiteMapProvider_invalid_GetRootNodeCore = "XmlSiteMapProvider_invalid_GetRootNodeCore";

	internal const string XmlSiteMapProvider_Error_loading_Config_file = "XmlSiteMapProvider_Error_loading_Config_file";

	internal const string XmlSiteMapProvider_FileName_does_not_exist = "XmlSiteMapProvider_FileName_does_not_exist";

	internal const string XmlSiteMapProvider_FileName_already_in_use = "XmlSiteMapProvider_FileName_already_in_use";

	internal const string XmlSiteMapProvider_Invalid_Extension = "XmlSiteMapProvider_Invalid_Extension";

	internal const string XmlSiteMapProvider_multiple_resource_definition = "XmlSiteMapProvider_multiple_resource_definition";

	internal const string UrlMappings_only_app_relative_url_allowed = "UrlMappings_only_app_relative_url_allowed";

	internal const string FileName_does_not_exist = "FileName_does_not_exist";

	internal const string SiteMapProvider_Multiple_Providers_With_Identical_Name = "SiteMapProvider_Multiple_Providers_With_Identical_Name";

	internal const string XmlSiteMapProvider_Multiple_Nodes_With_Identical_Url = "XmlSiteMapProvider_Multiple_Nodes_With_Identical_Url";

	internal const string XmlSiteMapProvider_Multiple_Nodes_With_Identical_Key = "XmlSiteMapProvider_Multiple_Nodes_With_Identical_Key";

	internal const string Provider_Not_Found = "Provider_Not_Found";

	internal const string Provider_does_not_support_policy_for_responses = "Provider_does_not_support_policy_for_responses";

	internal const string Provider_does_not_support_policy_for_fragments = "Provider_does_not_support_policy_for_fragments";

	internal const string GetOutputCacheProviderName_Invalid = "GetOutputCacheProviderName_Invalid";

	internal const string OutputCacheExtensibility_CantSerializeDeserializeType = "OutputCacheExtensibility_CantSerializeDeserializeType";

	internal const string Collection_readonly = "Collection_readonly";

	internal const string ParameterCollection_NotParameter = "ParameterCollection_NotParameter";

	internal const string ControlParameter_CouldNotFindControl = "ControlParameter_CouldNotFindControl";

	internal const string ControlParameter_ControlIDNotSpecified = "ControlParameter_ControlIDNotSpecified";

	internal const string ControlParameter_PropertyNameNotSpecified = "ControlParameter_PropertyNameNotSpecified";

	internal const string DataSourceCache_InvalidExpiryPolicy = "DataSourceCache_InvalidExpiryPolicy";

	internal const string DataSourceCache_InvalidDuration = "DataSourceCache_InvalidDuration";

	internal const string DataSourceCache_CacheMustBeEnabled = "DataSourceCache_CacheMustBeEnabled";

	internal const string DataSourceView_NoPaging = "DataSourceView_NoPaging";

	internal const string DataSourceView_NoSorting = "DataSourceView_NoSorting";

	internal const string DataSourceView_NoRowCount = "DataSourceView_NoRowCount";

	internal const string AccessDataSource_Description = "AccessDataSource_Description";

	internal const string AccessDataSource_DisplayName = "AccessDataSource_DisplayName";

	internal const string AccessDataSource_CannotSetConnectionString = "AccessDataSource_CannotSetConnectionString";

	internal const string AccessDataSource_CannotSetProvider = "AccessDataSource_CannotSetProvider";

	internal const string AccessDataSource_SqlCacheDependencyNotSupported = "AccessDataSource_SqlCacheDependencyNotSupported";

	internal const string AccessDataSource_DesignTimeRelativePathsNotSupported = "AccessDataSource_DesignTimeRelativePathsNotSupported";

	internal const string AccessDataSource_NoPathDiscoveryPermission = "AccessDataSource_NoPathDiscoveryPermission";

	internal const string AccessDataSourceView_SelectRequiresDataFile = "AccessDataSourceView_SelectRequiresDataFile";

	internal const string SqlDataSource_Description = "SqlDataSource_Description";

	internal const string SqlDataSource_DisplayName = "SqlDataSource_DisplayName";

	internal const string SqlDataSource_InvalidMode = "SqlDataSource_InvalidMode";

	internal const string SqlDataSource_SqlCacheDependencyNotSupported = "SqlDataSource_SqlCacheDependencyNotSupported";

	internal const string SqlDataSource_NoDbPermission = "SqlDataSource_NoDbPermission";

	internal const string SqlDataSourceView_SortNotSupported = "SqlDataSourceView_SortNotSupported";

	internal const string SqlDataSourceView_FilterNotSupported = "SqlDataSourceView_FilterNotSupported";

	internal const string SqlDataSourceView_CacheNotSupported = "SqlDataSourceView_CacheNotSupported";

	internal const string SqlDataSourceView_DeleteNotSupported = "SqlDataSourceView_DeleteNotSupported";

	internal const string SqlDataSourceView_InsertNotSupported = "SqlDataSourceView_InsertNotSupported";

	internal const string SqlDataSourceView_UpdateNotSupported = "SqlDataSourceView_UpdateNotSupported";

	internal const string SqlDataSourceView_CouldNotCreateConnection = "SqlDataSourceView_CouldNotCreateConnection";

	internal const string SqlDataSourceView_NoPaging = "SqlDataSourceView_NoPaging";

	internal const string SqlDataSourceView_NoSorting = "SqlDataSourceView_NoSorting";

	internal const string SqlDataSourceView_NoRowCount = "SqlDataSourceView_NoRowCount";

	internal const string SqlDataSourceView_CountNotValid = "SqlDataSourceView_CountNotValid";

	internal const string SqlDataSourceView_SortParameterRequiresStoredProcedure = "SqlDataSourceView_SortParameterRequiresStoredProcedure";

	internal const string SqlDataSourceView_CommandNotificationNotSupported = "SqlDataSourceView_CommandNotificationNotSupported";

	internal const string SqlDataSourceView_Pessimistic = "SqlDataSourceView_Pessimistic";

	internal const string SqlDataSourceView_MissingParameters = "SqlDataSourceView_MissingParameters";

	internal const string SqlDataSourceView_NoParameters = "SqlDataSourceView_NoParameters";

	internal const string DataSourceView_delete = "DataSourceView_delete";

	internal const string DataSourceView_update = "DataSourceView_update";

	internal const string ModelDataSourceView_CannotCallOpenGenericMethods = "ModelDataSourceView_CannotCallOpenGenericMethods";

	internal const string ModelDataSourceView_CannotCallMethodsWithOutOrRefParameters = "ModelDataSourceView_CannotCallMethodsWithOutOrRefParameters";

	internal const string ModelDataSourceView_DataMethodNotFound = "ModelDataSourceView_DataMethodNotFound";

	internal const string ModelDataSourceView_DeleteNotSupported = "ModelDataSourceView_DeleteNotSupported";

	internal const string ModelDataSourceView_InvalidSelectReturnType = "ModelDataSourceView_InvalidSelectReturnType";

	internal const string ModelDataSourceView_InvalidAsyncSelectReturnType = "ModelDataSourceView_InvalidAsyncSelectReturnType";

	internal const string ModelDataSourceView_UseAsyncMethodMustBeUsingAsyncPage = "ModelDataSourceView_UseAsyncMethodMustBeUsingAsyncPage";

	internal const string ModelDataSourceView_InvalidPagingParameters = "ModelDataSourceView_InvalidPagingParameters";

	internal const string ModelDataSourceView_InvalidAsyncPagingParameters = "ModelDataSourceView_InvalidAsyncPagingParameters";

	internal const string ModelDataSourceView_MustUseSelectResultAsReturnType = "ModelDataSourceView_MustUseSelectResultAsReturnType";

	internal const string ModelDataSourceView_InvalidSortingParameters = "ModelDataSourceView_InvalidSortingParameters";

	internal const string ModelDataSourceView_InsertNotSupported = "ModelDataSourceView_InsertNotSupported";

	internal const string ModelDataSourceView_MultipleModelMethodSources = "ModelDataSourceView_MultipleModelMethodSources";

	internal const string ModelDataSourceView_MultipleValueProvidersNotSupported = "ModelDataSourceView_MultipleValueProvidersNotSupported";

	internal const string ModelDataSourceView_UpdateNotSupported = "ModelDataSourceView_UpdateNotSupported";

	internal const string ModelDataSourceView_SelectNotSupported = "ModelDataSourceView_SelectNotSupported";

	internal const string ModelDataSourceView_SortNotSupportedOnIEnumerable = "ModelDataSourceView_SortNotSupportedOnIEnumerable";

	internal const string ModelDataSourceView_ParameterCannotBeNull = "ModelDataSourceView_ParameterCannotBeNull";

	internal const string ModelDataSourceView_ParameterValueHasWrongType = "ModelDataSourceView_ParameterValueHasWrongType";

	internal const string ModelDataSourceView_CancellationTokenIsNotSupported = "ModelDataSourceView_CancellationTokenIsNotSupported";

	internal const string ObjectDataSource_Description = "ObjectDataSource_Description";

	internal const string ObjectDataSource_DisplayName = "ObjectDataSource_DisplayName";

	internal const string ObjectDataSourceView_DeleteNotSupported = "ObjectDataSourceView_DeleteNotSupported";

	internal const string ObjectDataSourceView_InsertNotSupported = "ObjectDataSourceView_InsertNotSupported";

	internal const string ObjectDataSourceView_UpdateNotSupported = "ObjectDataSourceView_UpdateNotSupported";

	internal const string ObjectDataSourceView_SelectNotSupported = "ObjectDataSourceView_SelectNotSupported";

	internal const string ObjectDataSourceView_InsertRequiresValues = "ObjectDataSourceView_InsertRequiresValues";

	internal const string ObjectDataSourceView_TypeNotSpecified = "ObjectDataSourceView_TypeNotSpecified";

	internal const string ObjectDataSourceView_TypeNotFound = "ObjectDataSourceView_TypeNotFound";

	internal const string ObjectDataSourceView_MethodNotFoundNoParams = "ObjectDataSourceView_MethodNotFoundNoParams";

	internal const string ObjectDataSourceView_MethodNotFoundWithParams = "ObjectDataSourceView_MethodNotFoundWithParams";

	internal const string ObjectDataSourceView_MethodNotFoundForDataObject = "ObjectDataSourceView_MethodNotFoundForDataObject";

	internal const string ObjectDataSourceView_DataObjectTypeNotFound = "ObjectDataSourceView_DataObjectTypeNotFound";

	internal const string ObjectDataSourceView_DataObjectPropertyNotFound = "ObjectDataSourceView_DataObjectPropertyNotFound";

	internal const string ObjectDataSourceView_DataObjectPropertyReadOnly = "ObjectDataSourceView_DataObjectPropertyReadOnly";

	internal const string ObjectDataSourceView_MultipleOverloads = "ObjectDataSourceView_MultipleOverloads";

	internal const string ObjectDataSourceView_CacheNotSupportedOnSortedDataView = "ObjectDataSourceView_CacheNotSupportedOnSortedDataView";

	internal const string ObjectDataSourceView_CacheNotSupportedOnIDataReader = "ObjectDataSourceView_CacheNotSupportedOnIDataReader";

	internal const string ObjectDataSourceView_SortNotSupportedOnIEnumerable = "ObjectDataSourceView_SortNotSupportedOnIEnumerable";

	internal const string ObjectDataSourceView_FilterNotSupported = "ObjectDataSourceView_FilterNotSupported";

	internal const string ObjectDataSourceView_Pessimistic = "ObjectDataSourceView_Pessimistic";

	internal const string ObjectDataSourceView_NoOldValuesParams = "ObjectDataSourceView_NoOldValuesParams";

	internal const string ObjectDataSourceView_MissingPagingSettings = "ObjectDataSourceView_MissingPagingSettings";

	internal const string ObjectDataSourceView_CannotConvertType = "ObjectDataSourceView_CannotConvertType";

	internal const string FilteredDataSetHelper_DataSetHasNoTables = "FilteredDataSetHelper_DataSetHasNoTables";

	internal const string StringPropertyBuilder_CannotHaveChildObjects = "StringPropertyBuilder_CannotHaveChildObjects";

	internal const string XmlHierarchyData_CouldNotFindNode = "XmlHierarchyData_CouldNotFindNode";

	internal const string XmlDataSource_Description = "XmlDataSource_Description";

	internal const string XmlDataSource_DesignTimeRelativePathsNotSupported = "XmlDataSource_DesignTimeRelativePathsNotSupported";

	internal const string XmlDataSource_DisplayName = "XmlDataSource_DisplayName";

	internal const string XmlDataSource_SaveNotAllowed = "XmlDataSource_SaveNotAllowed";

	internal const string XmlDataSource_NoWebPermission = "XmlDataSource_NoWebPermission";

	internal const string XmlDataSource_CannotChangeWhileLoading = "XmlDataSource_CannotChangeWhileLoading";

	internal const string XmlDataSource_NeedUniqueIDForCache = "XmlDataSource_NeedUniqueIDForCache";

	internal const string XmlDataSource_CacheKeyContext = "XmlDataSource_CacheKeyContext";

	internal const string DataControlFieldCell_ShouldNotSetValidateRequestMode = "DataControlFieldCell_ShouldNotSetValidateRequestMode";

	internal const string NeedHeader = "NeedHeader";

	internal const string Form_Required_For_Focus = "Form_Required_For_Focus";

	internal const string Page_MustCallBeforeAndDuringPreRender = "Page_MustCallBeforeAndDuringPreRender";

	internal const string RoleGroupCollection_InvalidType = "RoleGroupCollection_InvalidType";

	internal const string Page_CallBackError = "Page_CallBackError";

	internal const string Page_CallBackInvalid = "Page_CallBackInvalid";

	internal const string Page_CallBackTargetInvalid = "Page_CallBackTargetInvalid";

	internal const string NoThemingSupport = "NoThemingSupport";

	internal const string ControlNonVisual = "ControlNonVisual";

	internal const string NoFocusSupport = "NoFocusSupport";

	internal const string PageStatePersister_PageCannotBeNull = "PageStatePersister_PageCannotBeNull";

	internal const string SessionPageStatePersister_SessionMustBeEnabled = "SessionPageStatePersister_SessionMustBeEnabled";

	internal const string Page_MissingDataBindingContext = "Page_MissingDataBindingContext";

	internal const string TemplateControl_DataBindingRequiresPage = "TemplateControl_DataBindingRequiresPage";

	internal const string LabelForNotFound = "LabelForNotFound";

	internal const string Attrib_Sql9_not_allowed = "Attrib_Sql9_not_allowed";

	internal const string FactoryGenerator_TypeNotPublic = "FactoryGenerator_TypeNotPublic";

	internal const string FactoryGenerator_TypeHasNoParameterlessConstructor = "FactoryGenerator_TypeHasNoParameterlessConstructor";

	internal const string FactoryInterface = "FactoryInterface";

	internal const string InvalidSerializedData = "InvalidSerializedData";

	internal const string NonSerializableType = "NonSerializableType";

	internal const string ErrorSerializingValue = "ErrorSerializingValue";

	internal const string Control_ValidateRequestMode = "Control_ValidateRequestMode";

	internal const string Control_Controls = "Control_Controls";

	internal const string Control_ID = "Control_ID";

	internal const string Control_MaintainState = "Control_MaintainState";

	internal const string Control_ViewStateMode = "Control_ViewStateMode";

	internal const string Control_Visible = "Control_Visible";

	internal const string Control_OnDisposed = "Control_OnDisposed";

	internal const string Control_OnInit = "Control_OnInit";

	internal const string Control_OnLoad = "Control_OnLoad";

	internal const string Control_OnUnload = "Control_OnUnload";

	internal const string Control_OnPreRender = "Control_OnPreRender";

	internal const string Control_OnDataBind = "Control_OnDataBind";

	internal const string Control_NamingContainer = "Control_NamingContainer";

	internal const string Control_Page = "Control_Page";

	internal const string Control_Parent = "Control_Parent";

	internal const string Control_TemplateSourceDirectory = "Control_TemplateSourceDirectory";

	internal const string Control_TemplateControl = "Control_TemplateControl";

	internal const string Control_Site = "Control_Site";

	internal const string Control_State = "Control_State";

	internal const string Control_UniqueID = "Control_UniqueID";

	internal const string Control_ClientID = "Control_ClientID";

	internal const string Control_ClientIDMode = "Control_ClientIDMode";

	internal const string Control_SkinId = "Control_SkinId";

	internal const string Control_EnableTheming = "Control_EnableTheming";

	internal const string Page_ClientTarget = "Page_ClientTarget";

	internal const string Page_ErrorPage = "Page_ErrorPage";

	internal const string Page_Error = "Page_Error";

	internal const string Page_OnCommitTransaction = "Page_OnCommitTransaction";

	internal const string Page_OnAbortTransaction = "Page_OnAbortTransaction";

	internal const string Page_Illegal_MaxPageStateFieldLength = "Page_Illegal_MaxPageStateFieldLength";

	internal const string Page_Illegal_AsyncTimeout = "Page_Illegal_AsyncTimeout";

	internal const string Page_InvalidUpdateModelAttempt = "Page_InvalidUpdateModelAttempt";

	internal const string Page_UnobtrusiveValidationMode = "Page_UnobtrusiveValidationMode";

	internal const string Page_UpdateModel_UpdateUnsuccessful = "Page_UpdateModel_UpdateUnsuccessful";

	internal const string ObjectDataSource_ConflictDetection = "ObjectDataSource_ConflictDetection";

	internal const string ObjectDataSource_ConvertNullToDBNull = "ObjectDataSource_ConvertNullToDBNull";

	internal const string ObjectDataSource_DataObjectTypeName = "ObjectDataSource_DataObjectTypeName";

	internal const string ObjectDataSource_DeleteMethod = "ObjectDataSource_DeleteMethod";

	internal const string ObjectDataSource_DeleteParameters = "ObjectDataSource_DeleteParameters";

	internal const string ObjectDataSource_EnablePaging = "ObjectDataSource_EnablePaging";

	internal const string ObjectDataSource_FilterExpression = "ObjectDataSource_FilterExpression";

	internal const string ObjectDataSource_FilterParameters = "ObjectDataSource_FilterParameters";

	internal const string ObjectDataSource_InsertMethod = "ObjectDataSource_InsertMethod";

	internal const string ObjectDataSource_InsertParameters = "ObjectDataSource_InsertParameters";

	internal const string ObjectDataSource_MaximumRowsParameterName = "ObjectDataSource_MaximumRowsParameterName";

	internal const string ObjectDataSource_SelectCountMethod = "ObjectDataSource_SelectCountMethod";

	internal const string ObjectDataSource_SelectMethod = "ObjectDataSource_SelectMethod";

	internal const string ObjectDataSource_SelectParameters = "ObjectDataSource_SelectParameters";

	internal const string ObjectDataSource_SortParameterName = "ObjectDataSource_SortParameterName";

	internal const string ObjectDataSource_StartRowIndexParameterName = "ObjectDataSource_StartRowIndexParameterName";

	internal const string ObjectDataSource_TypeName = "ObjectDataSource_TypeName";

	internal const string ObjectDataSource_UpdateMethod = "ObjectDataSource_UpdateMethod";

	internal const string ObjectDataSource_UpdateParameters = "ObjectDataSource_UpdateParameters";

	internal const string ObjectDataSource_ObjectCreated = "ObjectDataSource_ObjectCreated";

	internal const string ObjectDataSource_ObjectCreating = "ObjectDataSource_ObjectCreating";

	internal const string ObjectDataSource_ObjectDisposing = "ObjectDataSource_ObjectDisposing";

	internal const string ObjectDataSource_Selected = "ObjectDataSource_Selected";

	internal const string ObjectDataSource_Selecting = "ObjectDataSource_Selecting";

	internal const string ObjectDataSource_ParsingCulture = "ObjectDataSource_ParsingCulture";

	internal const string DataSourceCache_Duration = "DataSourceCache_Duration";

	internal const string DataSourceCache_Enabled = "DataSourceCache_Enabled";

	internal const string DataSourceCache_ExpirationPolicy = "DataSourceCache_ExpirationPolicy";

	internal const string DataSourceCache_KeyDependency = "DataSourceCache_KeyDependency";

	internal const string SqlDataSource_ConflictDetection = "SqlDataSource_ConflictDetection";

	internal const string SqlDataSource_ConnectionString = "SqlDataSource_ConnectionString";

	internal const string SqlDataSource_CancelSelectOnNullParameter = "SqlDataSource_CancelSelectOnNullParameter";

	internal const string SqlDataSource_ProviderName = "SqlDataSource_ProviderName";

	internal const string SqlDataSource_DataSourceMode = "SqlDataSource_DataSourceMode";

	internal const string SqlDataSource_DeleteCommand = "SqlDataSource_DeleteCommand";

	internal const string SqlDataSource_DeleteCommandType = "SqlDataSource_DeleteCommandType";

	internal const string SqlDataSource_DeleteParameters = "SqlDataSource_DeleteParameters";

	internal const string SqlDataSource_FilterExpression = "SqlDataSource_FilterExpression";

	internal const string SqlDataSource_FilterParameters = "SqlDataSource_FilterParameters";

	internal const string SqlDataSource_InsertCommand = "SqlDataSource_InsertCommand";

	internal const string SqlDataSource_InsertCommandType = "SqlDataSource_InsertCommandType";

	internal const string SqlDataSource_InsertParameters = "SqlDataSource_InsertParameters";

	internal const string SqlDataSource_SelectCommand = "SqlDataSource_SelectCommand";

	internal const string SqlDataSource_SelectCommandType = "SqlDataSource_SelectCommandType";

	internal const string SqlDataSource_SelectParameters = "SqlDataSource_SelectParameters";

	internal const string SqlDataSource_SortParameterName = "SqlDataSource_SortParameterName";

	internal const string SqlDataSource_UpdateCommand = "SqlDataSource_UpdateCommand";

	internal const string SqlDataSource_UpdateCommandType = "SqlDataSource_UpdateCommandType";

	internal const string SqlDataSource_UpdateParameters = "SqlDataSource_UpdateParameters";

	internal const string SqlDataSource_Selected = "SqlDataSource_Selected";

	internal const string SqlDataSource_Selecting = "SqlDataSource_Selecting";

	internal const string SqlDataSourceCache_SqlCacheDependency = "SqlDataSourceCache_SqlCacheDependency";

	internal const string Parameter_DbType = "Parameter_DbType";

	internal const string Parameter_DefaultValue = "Parameter_DefaultValue";

	internal const string Parameter_Direction = "Parameter_Direction";

	internal const string Parameter_Name = "Parameter_Name";

	internal const string Parameter_Size = "Parameter_Size";

	internal const string Parameter_ConvertEmptyStringToNull = "Parameter_ConvertEmptyStringToNull";

	internal const string Parameter_Type = "Parameter_Type";

	internal const string Parameter_TypeNotSupported = "Parameter_TypeNotSupported";

	internal const string Parameter_ValidateInput = "Parameter_ValidateInput";

	internal const string ControlParameter_ControlID = "ControlParameter_ControlID";

	internal const string ControlParameter_PropertyName = "ControlParameter_PropertyName";

	internal const string CookieParameter_CookieName = "CookieParameter_CookieName";

	internal const string QueryStringParameter_QueryStringField = "QueryStringParameter_QueryStringField";

	internal const string FormParameter_FormField = "FormParameter_FormField";

	internal const string SessionParameter_SessionField = "SessionParameter_SessionField";

	internal const string ProfileParameter_PropertyName = "ProfileParameter_PropertyName";

	internal const string HtmlInputHidden_OnServerChange = "HtmlInputHidden_OnServerChange";

	internal const string HtmlInputImage_OnServerClick = "HtmlInputImage_OnServerClick";

	internal const string HtmlInputText_ServerChange = "HtmlInputText_ServerChange";

	internal const string HtmlSelect_DataTextField = "HtmlSelect_DataTextField";

	internal const string HtmlSelect_DataValueField = "HtmlSelect_DataValueField";

	internal const string HtmlSelect_OnServerChange = "HtmlSelect_OnServerChange";

	internal const string HtmlSelect_DataMember = "HtmlSelect_DataMember";

	internal const string HtmlTextArea_OnServerChange = "HtmlTextArea_OnServerChange";

	internal const string AccessDataSource_DataFile = "AccessDataSource_DataFile";

	internal const string AdRotator_AdvertisementFile = "AdRotator_AdvertisementFile";

	internal const string AdRotator_AlternateTextField = "AdRotator_AlternateTextField";

	internal const string AdRotator_ImageUrlField = "AdRotator_ImageUrlField";

	internal const string AdRotator_KeywordFilter = "AdRotator_KeywordFilter";

	internal const string AdRotator_NavigateUrlField = "AdRotator_NavigateUrlField";

	internal const string AdRotator_Target = "AdRotator_Target";

	internal const string AdRotator_OnAdCreated = "AdRotator_OnAdCreated";

	internal const string AssemblyResourceLoader_HandlerNotRegistered = "AssemblyResourceLoader_HandlerNotRegistered";

	internal const string AssemblyResourceLoader_InvalidRequest = "AssemblyResourceLoader_InvalidRequest";

	internal const string AssemblyResourceLoader_AssemblyNotFound = "AssemblyResourceLoader_AssemblyNotFound";

	internal const string AssemblyResourceLoader_ResourceNotFound = "AssemblyResourceLoader_ResourceNotFound";

	internal const string AssemblyResourceLoader_NoCircularReferences = "AssemblyResourceLoader_NoCircularReferences";

	internal const string DataControls_ShowFooter = "DataControls_ShowFooter";

	internal const string DataControls_ShowHeader = "DataControls_ShowHeader";

	internal const string DataControls_AutoGenerateColumns = "DataControls_AutoGenerateColumns";

	internal const string Button_CausesValidation = "Button_CausesValidation";

	internal const string WebControl_RepeatLayout = "WebControl_RepeatLayout";

	internal const string DataSource_Updating = "DataSource_Updating";

	internal const string DataSource_Inserting = "DataSource_Inserting";

	internal const string DataSource_Deleting = "DataSource_Deleting";

	internal const string DataSource_Updated = "DataSource_Updated";

	internal const string DataSource_Inserted = "DataSource_Inserted";

	internal const string DataSource_Deleted = "DataSource_Deleted";

	internal const string TableItem_VerticalAlign = "TableItem_VerticalAlign";

	internal const string Button_PostBackUrl = "Button_PostBackUrl";

	internal const string LoginControls_DefaultRequiredFieldValidatorText = "LoginControls_DefaultRequiredFieldValidatorText";

	internal const string LoginControls_SuccessPageUrl = "LoginControls_SuccessPageUrl";

	internal const string LoginControls_EditProfileIconUrl = "LoginControls_EditProfileIconUrl";

	internal const string LoginControls_HelpPageIconUrl = "LoginControls_HelpPageIconUrl";

	internal const string LoginControls_HelpPageUrl = "LoginControls_HelpPageUrl";

	internal const string ChangePassword_ChangePasswordButtonImageUrl = "ChangePassword_ChangePasswordButtonImageUrl";

	internal const string ChangePassword_ContinueButtonImageUrl = "ChangePassword_ContinueButtonImageUrl";

	internal const string PagerSettings_PreviousPageText = "PagerSettings_PreviousPageText";

	internal const string PagerSettings_NextPageText = "PagerSettings_NextPageText";

	internal const string ChangePassword_UserNameRequiredErrorMessage = "ChangePassword_UserNameRequiredErrorMessage";

	internal const string ChangePassword_ConfirmPasswordCompareErrorMessage = "ChangePassword_ConfirmPasswordCompareErrorMessage";

	internal const string LoginControls_ConfirmPasswordRequiredErrorMessage = "LoginControls_ConfirmPasswordRequiredErrorMessage";

	internal const string LoginControls_AnswerRequiredErrorMessage = "LoginControls_AnswerRequiredErrorMessage";

	internal const string LoginControls_TitleText = "LoginControls_TitleText";

	internal const string ChangePassword_PasswordRecoveryText = "ChangePassword_PasswordRecoveryText";

	internal const string ChangePassword_ChangePasswordButtonText = "ChangePassword_ChangePasswordButtonText";

	internal const string ChangePassword_HelpPageText = "ChangePassword_HelpPageText";

	internal const string ChangePassword_CreateUserText = "ChangePassword_CreateUserText";

	internal const string ChangePassword_SuccessText = "ChangePassword_SuccessText";

	internal const string LoginControls_UserNameLabelText = "LoginControls_UserNameLabelText";

	internal const string WebControl_SkipLinkText = "WebControl_SkipLinkText";

	internal const string View_HeaderText = "View_HeaderText";

	internal const string View_FooterText = "View_FooterText";

	internal const string View_EmptyDataText = "View_EmptyDataText";

	internal const string BoundField_NullDisplayText = "BoundField_NullDisplayText";

	internal const string View_PagerTemplate = "View_PagerTemplate";

	internal const string WebControl_HeaderTemplate = "WebControl_HeaderTemplate";

	internal const string View_EmptyDataTemplate = "View_EmptyDataTemplate";

	internal const string LoginControls_TitleTextStyle = "LoginControls_TitleTextStyle";

	internal const string LoginControls_TextBoxStyle = "LoginControls_TextBoxStyle";

	internal const string LoginControls_LabelStyle = "LoginControls_LabelStyle";

	internal const string WebControl_InstructionTextStyle = "WebControl_InstructionTextStyle";

	internal const string WebControl_HyperLinkStyle = "WebControl_HyperLinkStyle";

	internal const string WebControl_FailureTextStyle = "WebControl_FailureTextStyle";

	internal const string View_EmptyDataRowStyle = "View_EmptyDataRowStyle";

	internal const string WebControl_HeaderStyle = "WebControl_HeaderStyle";

	internal const string View_RowStyle = "View_RowStyle";

	internal const string View_InsertRowStyle = "View_InsertRowStyle";

	internal const string View_EditRowStyle = "View_EditRowStyle";

	internal const string DataControls_Columns = "DataControls_Columns";

	internal const string HotSpot_Target = "HotSpot_Target";

	internal const string MembershipProvider_Name = "MembershipProvider_Name";

	internal const string View_DefaultMode = "View_DefaultMode";

	internal const string LoginControls_TextLayout = "LoginControls_TextLayout";

	internal const string UserName_InitialValue = "UserName_InitialValue";

	internal const string WebControl_SelectedIndex = "WebControl_SelectedIndex";

	internal const string View_DataSourceReturnedNullView = "View_DataSourceReturnedNullView";

	internal const string WebControl_HorizontalAlign = "WebControl_HorizontalAlign";

	internal const string TableItem_HorizontalAlign = "TableItem_HorizontalAlign";

	internal const string DataSource_OldValuesParameterFormatString = "DataSource_OldValuesParameterFormatString";

	internal const string Binding_DataMember = "Binding_DataMember";

	internal const string Item_RepeatDirection = "Item_RepeatDirection";

	internal const string DataControls_Caption = "DataControls_Caption";

	internal const string DataSource_InvalidViewName = "DataSource_InvalidViewName";

	internal const string WebControl_CommandName = "WebControl_CommandName";

	internal const string WebControl_CommandArgument = "WebControl_CommandArgument";

	internal const string WebControl_BackImageUrl = "WebControl_BackImageUrl";

	internal const string WebControl_TextAlign = "WebControl_TextAlign";

	internal const string WebControl_CaptionAlign = "WebControl_CaptionAlign";

	internal const string WebControl_InstructionText = "WebControl_InstructionText";

	internal const string DataControls_HeaderStyle = "DataControls_HeaderStyle";

	internal const string DataControls_FooterStyle = "DataControls_FooterStyle";

	internal const string HotSpot_HotSpotMode = "HotSpot_HotSpotMode";

	internal const string DataControls_GridLines = "DataControls_GridLines";

	internal const string Password_InvalidPasswordErrorMessage = "Password_InvalidPasswordErrorMessage";

	internal const string Table_UseAccessibleHeader = "Table_UseAccessibleHeader";

	internal const string HtmlControl_OnServerClick = "HtmlControl_OnServerClick";

	internal const string Button_OnCommand = "Button_OnCommand";

	internal const string Control_OnServerCheckChanged = "Control_OnServerCheckChanged";

	internal const string DataControls_OnItemUpdated = "DataControls_OnItemUpdated";

	internal const string DataControls_OnItemDeleting = "DataControls_OnItemDeleting";

	internal const string DataControls_OnItemInserting = "DataControls_OnItemInserting";

	internal const string DataControls_OnItemUpdating = "DataControls_OnItemUpdating";

	internal const string DataControls_OnItemCreated = "DataControls_OnItemCreated";

	internal const string DataControls_OnItemDataBound = "DataControls_OnItemDataBound";

	internal const string DataControls_OnItemDeleted = "DataControls_OnItemDeleted";

	internal const string DataControls_OnItemInserted = "DataControls_OnItemInserted";

	internal const string DataControls_DataKeyNames = "DataControls_DataKeyNames";

	internal const string DataControls_DataSourceMustBeCollectionWhenNotDataBinding = "DataControls_DataSourceMustBeCollectionWhenNotDataBinding";

	internal const string DataControls_OnRowDeleted = "DataControls_OnRowDeleted";

	internal const string DataSource_Filtering = "DataSource_Filtering";

	internal const string WebControl_PagerStyle = "WebControl_PagerStyle";

	internal const string WebControl_CantFindProvider = "WebControl_CantFindProvider";

	internal const string BaseDataList_CellPadding = "BaseDataList_CellPadding";

	internal const string BaseDataList_CellSpacing = "BaseDataList_CellSpacing";

	internal const string BaseDataList_DataKeyField = "BaseDataList_DataKeyField";

	internal const string BaseDataList_DataKeys = "BaseDataList_DataKeys";

	internal const string BaseDataList_DataMember = "BaseDataList_DataMember";

	internal const string BaseDataList_OnSelectedIndexChanged = "BaseDataList_OnSelectedIndexChanged";

	internal const string BaseValidator_ControlToValidate = "BaseValidator_ControlToValidate";

	internal const string BaseValidator_ErrorMessage = "BaseValidator_ErrorMessage";

	internal const string BaseValidator_IsValid = "BaseValidator_IsValid";

	internal const string BaseValidator_Display = "BaseValidator_Display";

	internal const string BaseValidator_EnableClientScript = "BaseValidator_EnableClientScript";

	internal const string BaseValidator_SetFocusOnError = "BaseValidator_SetFocusOnError";

	internal const string BaseValidator_Text = "BaseValidator_Text";

	internal const string BaseValidator_ValidationGroup = "BaseValidator_ValidationGroup";

	internal const string BaseCompareValidator_CultureInvariantValues = "BaseCompareValidator_CultureInvariantValues";

	internal const string BoundColumn_DataField = "BoundColumn_DataField";

	internal const string BoundColumn_DataFormatString = "BoundColumn_DataFormatString";

	internal const string BoundColumn_ReadOnly = "BoundColumn_ReadOnly";

	internal const string BoundField_ApplyFormatInEditMode = "BoundField_ApplyFormatInEditMode";

	internal const string BoundField_DataField = "BoundField_DataField";

	internal const string BoundField_DataFormatString = "BoundField_DataFormatString";

	internal const string BoundField_HtmlEncode = "BoundField_HtmlEncode";

	internal const string BoundField_ReadOnly = "BoundField_ReadOnly";

	internal const string BoundField_ConvertEmptyStringToNull = "BoundField_ConvertEmptyStringToNull";

	internal const string BulletedList_BulletedListDisplayMode = "BulletedList_BulletedListDisplayMode";

	internal const string BulletedList_BulletImageUrl = "BulletedList_BulletImageUrl";

	internal const string BulletedList_BulletStyle = "BulletedList_BulletStyle";

	internal const string BulletedList_FirstBulletNumber = "BulletedList_FirstBulletNumber";

	internal const string BulletedList_Target = "BulletedList_Target";

	internal const string BulletedList_OnClick = "BulletedList_OnClick";

	internal const string Button_OnClientClick = "Button_OnClientClick";

	internal const string ButtonColumn_ButtonType = "ButtonColumn_ButtonType";

	internal const string ButtonColumn_CausesValidation = "ButtonColumn_CausesValidation";

	internal const string ButtonColumn_DataTextField = "ButtonColumn_DataTextField";

	internal const string ButtonColumn_DataTextFormatString = "ButtonColumn_DataTextFormatString";

	internal const string ButtonColumn_Text = "ButtonColumn_Text";

	internal const string ButtonColumn_ValidationGroup = "ButtonColumn_ValidationGroup";

	internal const string Button_Text = "Button_Text";

	internal const string Button_OnClick = "Button_OnClick";

	internal const string Button_UseSubmitBehavior = "Button_UseSubmitBehavior";

	internal const string CheckBox_AutoPostBack = "CheckBox_AutoPostBack";

	internal const string CheckBox_Checked = "CheckBox_Checked";

	internal const string CheckBox_InputAttributes = "CheckBox_InputAttributes";

	internal const string CheckBox_LabelAttributes = "CheckBox_LabelAttributes";

	internal const string CheckBox_Text = "CheckBox_Text";

	internal const string CheckBoxField_Text = "CheckBoxField_Text";

	internal const string CheckBoxList_CellPadding = "CheckBoxList_CellPadding";

	internal const string CheckBoxList_CellSpacing = "CheckBoxList_CellSpacing";

	internal const string CheckBoxList_RepeatColumns = "CheckBoxList_RepeatColumns";

	internal const string CircleHotSpot_X = "CircleHotSpot_X";

	internal const string CircleHotSpot_Y = "CircleHotSpot_Y";

	internal const string CircleHotSpot_Radius = "CircleHotSpot_Radius";

	internal const string CommandField_DefaultCancelCaption = "CommandField_DefaultCancelCaption";

	internal const string CommandField_DefaultDeleteCaption = "CommandField_DefaultDeleteCaption";

	internal const string CommandField_DefaultEditCaption = "CommandField_DefaultEditCaption";

	internal const string CommandField_DefaultInsertCaption = "CommandField_DefaultInsertCaption";

	internal const string CommandField_DefaultNewCaption = "CommandField_DefaultNewCaption";

	internal const string CommandField_DefaultSelectCaption = "CommandField_DefaultSelectCaption";

	internal const string CommandField_DefaultUpdateCaption = "CommandField_DefaultUpdateCaption";

	internal const string CommandField_CancelImageUrl = "CommandField_CancelImageUrl";

	internal const string CommandField_DeleteImageUrl = "CommandField_DeleteImageUrl";

	internal const string CommandField_EditImageUrl = "CommandField_EditImageUrl";

	internal const string CommandField_InsertImageUrl = "CommandField_InsertImageUrl";

	internal const string CommandField_NewImageUrl = "CommandField_NewImageUrl";

	internal const string CommandField_SelectImageUrl = "CommandField_SelectImageUrl";

	internal const string CommandField_UpdateImageUrl = "CommandField_UpdateImageUrl";

	internal const string CommandField_ShowDeleteButton = "CommandField_ShowDeleteButton";

	internal const string CommandField_ShowCancelButton = "CommandField_ShowCancelButton";

	internal const string CommandField_ShowInsertButton = "CommandField_ShowInsertButton";

	internal const string CommandField_ShowEditButton = "CommandField_ShowEditButton";

	internal const string CommandField_ShowSelectButton = "CommandField_ShowSelectButton";

	internal const string CommandField_CancelText = "CommandField_CancelText";

	internal const string CommandField_DeleteText = "CommandField_DeleteText";

	internal const string CommandField_EditText = "CommandField_EditText";

	internal const string CommandField_InsertText = "CommandField_InsertText";

	internal const string CommandField_NewText = "CommandField_NewText";

	internal const string CommandField_SelectText = "CommandField_SelectText";

	internal const string CommandField_UpdateText = "CommandField_UpdateText";

	internal const string ButtonFieldBase_ButtonType = "ButtonFieldBase_ButtonType";

	internal const string ButtonFieldBase_CausesValidation = "ButtonFieldBase_CausesValidation";

	internal const string ButtonFieldBase_ValidationGroup = "ButtonFieldBase_ValidationGroup";

	internal const string ButtonField_DataTextField = "ButtonField_DataTextField";

	internal const string ButtonField_DataTextFormatString = "ButtonField_DataTextFormatString";

	internal const string ButtonField_ImageUrl = "ButtonField_ImageUrl";

	internal const string ButtonField_Text = "ButtonField_Text";

	internal const string ChangePassword_CancelButtonType = "ChangePassword_CancelButtonType";

	internal const string ChangePassword_ContinueButtonType = "ChangePassword_ContinueButtonType";

	internal const string ChangePassword_ChangePasswordButtonType = "ChangePassword_ChangePasswordButtonType";

	internal const string ChangePassword_CancelButtonImageUrl = "ChangePassword_CancelButtonImageUrl";

	internal const string ChangePassword_CancelButtonText = "ChangePassword_CancelButtonText";

	internal const string ChangePassword_CancelButtonStyle = "ChangePassword_CancelButtonStyle";

	internal const string ChangePassword_CancelButtonClick = "ChangePassword_CancelButtonClick";

	internal const string ChangePassword_CancelDestinationPageUrl = "ChangePassword_CancelDestinationPageUrl";

	internal const string ChangePassword_ChangePasswordError = "ChangePassword_ChangePasswordError";

	internal const string ChangePassword_ChangedPassword = "ChangePassword_ChangedPassword";

	internal const string ChangePassword_ChangingPassword = "ChangePassword_ChangingPassword";

	internal const string ChangePassword_ChangePasswordFailureText = "ChangePassword_ChangePasswordFailureText";

	internal const string ChangePassword_ContinueButtonClick = "ChangePassword_ContinueButtonClick";

	internal const string LoginControls_ContinueDestinationPageUrl = "LoginControls_ContinueDestinationPageUrl";

	internal const string ChangePassword_ContinueButtonText = "ChangePassword_ContinueButtonText";

	internal const string ChangePassword_ContinueButtonStyle = "ChangePassword_ContinueButtonStyle";

	internal const string ChangePassword_CreateUserIconUrl = "ChangePassword_CreateUserIconUrl";

	internal const string ChangePassword_CreateUserUrl = "ChangePassword_CreateUserUrl";

	internal const string ChangePassword_DefaultChangePasswordTitleText = "ChangePassword_DefaultChangePasswordTitleText";

	internal const string ChangePassword_DefaultChangePasswordFailureText = "ChangePassword_DefaultChangePasswordFailureText";

	internal const string ChangePassword_DefaultCancelButtonText = "ChangePassword_DefaultCancelButtonText";

	internal const string ChangePassword_DefaultConfirmPasswordRequiredErrorMessage = "ChangePassword_DefaultConfirmPasswordRequiredErrorMessage";

	internal const string ChangePassword_DefaultConfirmNewPasswordLabelText = "ChangePassword_DefaultConfirmNewPasswordLabelText";

	internal const string ChangePassword_DefaultContinueButtonText = "ChangePassword_DefaultContinueButtonText";

	internal const string ChangePassword_DefaultNewPasswordLabelText = "ChangePassword_DefaultNewPasswordLabelText";

	internal const string ChangePassword_DefaultNewPasswordRequiredErrorMessage = "ChangePassword_DefaultNewPasswordRequiredErrorMessage";

	internal const string ChangePassword_DefaultConfirmPasswordCompareErrorMessage = "ChangePassword_DefaultConfirmPasswordCompareErrorMessage";

	internal const string ChangePassword_DefaultPasswordRequiredErrorMessage = "ChangePassword_DefaultPasswordRequiredErrorMessage";

	internal const string ChangePassword_DefaultChangePasswordButtonText = "ChangePassword_DefaultChangePasswordButtonText";

	internal const string ChangePassword_DefaultSuccessTitleText = "ChangePassword_DefaultSuccessTitleText";

	internal const string ChangePassword_DefaultSuccessText = "ChangePassword_DefaultSuccessText";

	internal const string ChangePassword_DefaultUserNameLabelText = "ChangePassword_DefaultUserNameLabelText";

	internal const string ChangePassword_DefaultUserNameRequiredErrorMessage = "ChangePassword_DefaultUserNameRequiredErrorMessage";

	internal const string ChangePassword_EditProfileText = "ChangePassword_EditProfileText";

	internal const string ChangePassword_EditProfileUrl = "ChangePassword_EditProfileUrl";

	internal const string ChangePassword_DisplayUserName = "ChangePassword_DisplayUserName";

	internal const string ChangePassword_InvalidBorderPadding = "ChangePassword_InvalidBorderPadding";

	internal const string ChangePassword_PasswordHintText = "ChangePassword_PasswordHintText";

	internal const string ChangePassword_MailDefinition = "ChangePassword_MailDefinition";

	internal const string ChangePassword_NewPasswordRegularExpressionErrorMessage = "ChangePassword_NewPasswordRegularExpressionErrorMessage";

	internal const string ChangePassword_NewPasswordLabelText = "ChangePassword_NewPasswordLabelText";

	internal const string ChangePassword_NewPasswordRegularExpression = "ChangePassword_NewPasswordRegularExpression";

	internal const string ChangePassword_NewPasswordRequiredErrorMessage = "ChangePassword_NewPasswordRequiredErrorMessage";

	internal const string ChangePassword_NoCurrentPasswordTextBox = "ChangePassword_NoCurrentPasswordTextBox";

	internal const string ChangePassword_NoNewPasswordTextBox = "ChangePassword_NoNewPasswordTextBox";

	internal const string ChangePassword_NoUserNameTextBox = "ChangePassword_NoUserNameTextBox";

	internal const string ChangePassword_UserNameTextBoxNotAllowed = "ChangePassword_UserNameTextBoxNotAllowed";

	internal const string ChangePassword_PasswordHintStyle = "ChangePassword_PasswordHintStyle";

	internal const string ChangePassword_PasswordRecoveryIconUrl = "ChangePassword_PasswordRecoveryIconUrl";

	internal const string ChangePassword_PasswordRecoveryUrl = "ChangePassword_PasswordRecoveryUrl";

	internal const string ChangePassword_PasswordRequiredErrorMessage = "ChangePassword_PasswordRequiredErrorMessage";

	internal const string ChangePassword_SendingMail = "ChangePassword_SendingMail";

	internal const string ChangePassword_SendMailError = "ChangePassword_SendMailError";

	internal const string ChangePassword_ChangePasswordButtonStyle = "ChangePassword_ChangePasswordButtonStyle";

	internal const string ChangePassword_SuccessTitleText = "ChangePassword_SuccessTitleText";

	internal const string ChangePassword_SuccessTextStyle = "ChangePassword_SuccessTextStyle";

	internal const string ChangePassword_ConfirmNewPasswordLabelText = "ChangePassword_ConfirmNewPasswordLabelText";

	internal const string ChangePassword_ValidatorTextStyle = "ChangePassword_ValidatorTextStyle";

	internal const string CompareValidator_ControlToCompare = "CompareValidator_ControlToCompare";

	internal const string CompareValidator_Operator = "CompareValidator_Operator";

	internal const string CompareValidator_ValueToCompare = "CompareValidator_ValueToCompare";

	internal const string Content_ContentPlaceHolderID = "Content_ContentPlaceHolderID";

	internal const string ContentPlaceHolder_only_in_master = "ContentPlaceHolder_only_in_master";

	internal const string ContentPlaceHolder_duplicate_contentPlaceHolderID = "ContentPlaceHolder_duplicate_contentPlaceHolderID";

	internal const string CreateUserWizard_AutoGeneratePassword = "CreateUserWizard_AutoGeneratePassword";

	internal const string CreateUserWizard_Answer = "CreateUserWizard_Answer";

	internal const string CreateUserWizard_InvalidAnswerErrorMessage = "CreateUserWizard_InvalidAnswerErrorMessage";

	internal const string CreateUserWizard_AnswerLabelText = "CreateUserWizard_AnswerLabelText";

	internal const string CreateUserWizard_CompleteSuccessText = "CreateUserWizard_CompleteSuccessText";

	internal const string CreateUserWizard_ContinueButtonType = "CreateUserWizard_ContinueButtonType";

	internal const string CreateUserWizard_CreatingUser = "CreateUserWizard_CreatingUser";

	internal const string CreateUserWizard_CreatedUser = "CreateUserWizard_CreatedUser";

	internal const string CreateUserWizard_ConfirmPasswordLabelText = "CreateUserWizard_ConfirmPasswordLabelText";

	internal const string CreateUserWizard_ContinueButtonText = "CreateUserWizard_ContinueButtonText";

	internal const string CreateUserWizard_ContinueButtonStyle = "CreateUserWizard_ContinueButtonStyle";

	internal const string CreateUserWizard_ContinueButtonClick = "CreateUserWizard_ContinueButtonClick";

	internal const string CreateUserWizard_CreateUserButtonImageUrl = "CreateUserWizard_CreateUserButtonImageUrl";

	internal const string CreateUserWizard_CreateUserButtonType = "CreateUserWizard_CreateUserButtonType";

	internal const string CreateUserWizard_CreateUserButtonText = "CreateUserWizard_CreateUserButtonText";

	internal const string CreateUserWizard_CreateUserButtonStyle = "CreateUserWizard_CreateUserButtonStyle";

	internal const string CreateUserWizard_CreateUserError = "CreateUserWizard_CreateUserError";

	internal const string CreateUserWizard_CreateUserStep = "CreateUserWizard_CreateUserStep";

	internal const string CreateUserWizard_DefaultConfirmPasswordCompareErrorMessage = "CreateUserWizard_DefaultConfirmPasswordCompareErrorMessage";

	internal const string CreateUserWizard_DefaultConfirmPasswordRequiredErrorMessage = "CreateUserWizard_DefaultConfirmPasswordRequiredErrorMessage";

	internal const string CreateUserWizard_DefaultConfirmPasswordLabelText = "CreateUserWizard_DefaultConfirmPasswordLabelText";

	internal const string CreateUserWizard_DefaultContinueButtonText = "CreateUserWizard_DefaultContinueButtonText";

	internal const string CreateUserWizard_DefaultCreateUserButtonText = "CreateUserWizard_DefaultCreateUserButtonText";

	internal const string CreateUserWizard_DefaultDuplicateUserNameErrorMessage = "CreateUserWizard_DefaultDuplicateUserNameErrorMessage";

	internal const string CreateUserWizard_DefaultDuplicateEmailErrorMessage = "CreateUserWizard_DefaultDuplicateEmailErrorMessage";

	internal const string CreateUserWizard_DefaultEmailLabelText = "CreateUserWizard_DefaultEmailLabelText";

	internal const string CreateUserWizard_DefaultUnknownErrorMessage = "CreateUserWizard_DefaultUnknownErrorMessage";

	internal const string CreateUserWizard_DefaultInvalidEmailErrorMessage = "CreateUserWizard_DefaultInvalidEmailErrorMessage";

	internal const string CreateUserWizard_DefaultInvalidPasswordErrorMessage = "CreateUserWizard_DefaultInvalidPasswordErrorMessage";

	internal const string CreateUserWizard_DefaultCompleteTitleText = "CreateUserWizard_DefaultCompleteTitleText";

	internal const string CreateUserWizard_DefaultPasswordRequiredErrorMessage = "CreateUserWizard_DefaultPasswordRequiredErrorMessage";

	internal const string CreateUserWizard_DefaultQuestionLabelText = "CreateUserWizard_DefaultQuestionLabelText";

	internal const string CreateUserWizard_DefaultInvalidQuestionErrorMessage = "CreateUserWizard_DefaultInvalidQuestionErrorMessage";

	internal const string CreateUserWizard_DefaultInvalidAnswerErrorMessage = "CreateUserWizard_DefaultInvalidAnswerErrorMessage";

	internal const string CreateUserWizard_DefaultAnswerLabelText = "CreateUserWizard_DefaultAnswerLabelText";

	internal const string CreateUserWizard_DefaultEmailRegularExpressionErrorMessage = "CreateUserWizard_DefaultEmailRegularExpressionErrorMessage";

	internal const string CreateUserWizard_DefaultCompleteSuccessText = "CreateUserWizard_DefaultCompleteSuccessText";

	internal const string CreateUserWizard_DefaultCreateUserTitleText = "CreateUserWizard_DefaultCreateUserTitleText";

	internal const string CreateUserWizard_DefaultUserNameLabelText = "CreateUserWizard_DefaultUserNameLabelText";

	internal const string CreateUserWizard_DefaultUserNameRequiredErrorMessage = "CreateUserWizard_DefaultUserNameRequiredErrorMessage";

	internal const string CreateUserWizard_DefaultAnswerRequiredErrorMessage = "CreateUserWizard_DefaultAnswerRequiredErrorMessage";

	internal const string CreateUserWizard_DefaultEmailRequiredErrorMessage = "CreateUserWizard_DefaultEmailRequiredErrorMessage";

	internal const string CreateUserWizard_DefaultQuestionRequiredErrorMessage = "CreateUserWizard_DefaultQuestionRequiredErrorMessage";

	internal const string CreateUserWizard_DuplicateEmailErrorMessage = "CreateUserWizard_DuplicateEmailErrorMessage";

	internal const string CreateUserWizard_DuplicateUserNameErrorMessage = "CreateUserWizard_DuplicateUserNameErrorMessage";

	internal const string CreateUserWizard_EditProfileText = "CreateUserWizard_EditProfileText";

	internal const string CreateUserWizard_EditProfileUrl = "CreateUserWizard_EditProfileUrl";

	internal const string CreateUserWizard_Email = "CreateUserWizard_Email";

	internal const string CreateUserWizard_EmailRegularExpression = "CreateUserWizard_EmailRegularExpression";

	internal const string CreateUserWizard_EmailRegularExpressionErrorMessage = "CreateUserWizard_EmailRegularExpressionErrorMessage";

	internal const string CreateUserWizard_InvalidEmailErrorMessage = "CreateUserWizard_InvalidEmailErrorMessage";

	internal const string CreateUserWizard_EmailLabelText = "CreateUserWizard_EmailLabelText";

	internal const string CreateUserWizard_UnknownErrorMessage = "CreateUserWizard_UnknownErrorMessage";

	internal const string CreateUserWizard_CompleteStep = "CreateUserWizard_CompleteStep";

	internal const string CreateUserWizard_DisableCreatedUser = "CreateUserWizard_DisableCreatedUser";

	internal const string CreateUserWizard_LoginCreatedUser = "CreateUserWizard_LoginCreatedUser";

	internal const string CreateUserWizard_QuestionAndAnswerRequired = "CreateUserWizard_QuestionAndAnswerRequired";

	internal const string CreateUserWizard_RequireEmail = "CreateUserWizard_RequireEmail";

	internal const string CreateUserWizard_ErrorMessageStyle = "CreateUserWizard_ErrorMessageStyle";

	internal const string CreateUserWizard_PasswordHintStyle = "CreateUserWizard_PasswordHintStyle";

	internal const string CreateUserWizard_MailDefinition = "CreateUserWizard_MailDefinition";

	internal const string CreateUserWizard_InvalidPasswordErrorMessage = "CreateUserWizard_InvalidPasswordErrorMessage";

	internal const string CreateUserWizard_PasswordRegularExpression = "CreateUserWizard_PasswordRegularExpression";

	internal const string CreateUserWizard_PasswordRegularExpressionErrorMessage = "CreateUserWizard_PasswordRegularExpressionErrorMessage";

	internal const string CreateUserWizard_PasswordRequiredErrorMessage = "CreateUserWizard_PasswordRequiredErrorMessage";

	internal const string CreateUserWizard_NoPasswordTextBox = "CreateUserWizard_NoPasswordTextBox";

	internal const string CreateUserWizard_NoUserNameTextBox = "CreateUserWizard_NoUserNameTextBox";

	internal const string CreateUserWizard_NoEmailTextBox = "CreateUserWizard_NoEmailTextBox";

	internal const string CreateUserWizard_NoQuestionTextBox = "CreateUserWizard_NoQuestionTextBox";

	internal const string CreateUserWizard_NoAnswerTextBox = "CreateUserWizard_NoAnswerTextBox";

	internal const string CreateUserWizard_Question = "CreateUserWizard_Question";

	internal const string CreateUserWizard_InvalidQuestionErrorMessage = "CreateUserWizard_InvalidQuestionErrorMessage";

	internal const string CreateUserWizard_QuestionLabelText = "CreateUserWizard_QuestionLabelText";

	internal const string CreateUserWizard_QuestionRequiredErrorMessage = "CreateUserWizard_QuestionRequiredErrorMessage";

	internal const string CreateUserWizard_EmailRequiredErrorMessage = "CreateUserWizard_EmailRequiredErrorMessage";

	internal const string CreateUserWizard_SendMailError = "CreateUserWizard_SendMailError";

	internal const string CreateUserWizard_SideBar_Label_Not_Found = "CreateUserWizard_SideBar_Label_Not_Found";

	internal const string CreateUserWizard_CompleteSuccessTextStyle = "CreateUserWizard_CompleteSuccessTextStyle";

	internal const string CreateUserWizard_DuplicateCreateUserWizardStep = "CreateUserWizard_DuplicateCreateUserWizardStep";

	internal const string CreateUserWizard_DuplicateCompleteWizardStep = "CreateUserWizard_DuplicateCompleteWizardStep";

	internal const string CreateUserWizard_ValidatorTextStyle = "CreateUserWizard_ValidatorTextStyle";

	internal const string TemplatedWizardStep_ContentTemplate = "TemplatedWizardStep_ContentTemplate";

	internal const string TemplatedWizardStep_CustomNavigationTemplate = "TemplatedWizardStep_CustomNavigationTemplate";

	internal const string CreateUserWizardStep_AllowReturnCannotBeSet = "CreateUserWizardStep_AllowReturnCannotBeSet";

	internal const string CreateUserWizardStep_StepTypeCannotBeSet = "CreateUserWizardStep_StepTypeCannotBeSet";

	internal const string CreateUserWizardStep_OnlyAllowedInCreateUserWizard = "CreateUserWizardStep_OnlyAllowedInCreateUserWizard";

	internal const string CompleteWizardStep_OnlyAllowedInCreateUserWizard = "CompleteWizardStep_OnlyAllowedInCreateUserWizard";

	internal const string CustomValidator_ClientValidationFunction = "CustomValidator_ClientValidationFunction";

	internal const string CustomValidator_ValidateEmptyText = "CustomValidator_ValidateEmptyText";

	internal const string CustomValidator_ServerValidate = "CustomValidator_ServerValidate";

	internal const string BaseDataBoundControl_DataSourceID = "BaseDataBoundControl_DataSourceID";

	internal const string BaseDataBoundControl_DataSource = "BaseDataBoundControl_DataSource";

	internal const string BaseDataBoundControl_OnDataBound = "BaseDataBoundControl_OnDataBound";

	internal const string DataBoundControl_DataMember = "DataBoundControl_DataMember";

	internal const string DataBoundControl_EnableModelValidation = "DataBoundControl_EnableModelValidation";

	internal const string DataBoundControl_ItemType = "DataBoundControl_ItemType";

	internal const string DataBoundControl_SelectMethod = "DataBoundControl_SelectMethod";

	internal const string DataBoundControl_UpdateMethod = "DataBoundControl_UpdateMethod";

	internal const string DataBoundControl_InsertMethod = "DataBoundControl_InsertMethod";

	internal const string DataBoundControl_DeleteMethod = "DataBoundControl_DeleteMethod";

	internal const string DataControlField_AccessibleHeaderText = "DataControlField_AccessibleHeaderText";

	internal const string DataControlField_ControlStyle = "DataControlField_ControlStyle";

	internal const string DataControlField_FooterStyle = "DataControlField_FooterStyle";

	internal const string DataControlField_FooterText = "DataControlField_FooterText";

	internal const string DataControlField_HeaderImageUrl = "DataControlField_HeaderImageUrl";

	internal const string DataControlField_HeaderStyle = "DataControlField_HeaderStyle";

	internal const string DataControlField_HeaderText = "DataControlField_HeaderText";

	internal const string DataControlField_InsertVisible = "DataControlField_InsertVisible";

	internal const string DataControlField_ItemStyle = "DataControlField_ItemStyle";

	internal const string DataControlField_ShowHeader = "DataControlField_ShowHeader";

	internal const string DataControlField_SortExpression = "DataControlField_SortExpression";

	internal const string DataControlField_Visible = "DataControlField_Visible";

	internal const string DataGrid_AllowCustomPaging = "DataGrid_AllowCustomPaging";

	internal const string DataGrid_AllowPaging = "DataGrid_AllowPaging";

	internal const string DataGrid_AllowSorting = "DataGrid_AllowSorting";

	internal const string DataGrid_AlternatingItemStyle = "DataGrid_AlternatingItemStyle";

	internal const string DataGrid_CurrentPageIndex = "DataGrid_CurrentPageIndex";

	internal const string DataGrid_EditItemIndex = "DataGrid_EditItemIndex";

	internal const string DataGrid_EditItemStyle = "DataGrid_EditItemStyle";

	internal const string DataGrid_ItemStyle = "DataGrid_ItemStyle";

	internal const string DataGrid_Items = "DataGrid_Items";

	internal const string DataGrid_PageCount = "DataGrid_PageCount";

	internal const string DataGrid_PagerStyle = "DataGrid_PagerStyle";

	internal const string DataGrid_PageSize = "DataGrid_PageSize";

	internal const string DataGrid_SelectedItem = "DataGrid_SelectedItem";

	internal const string DataGrid_SelectedItemStyle = "DataGrid_SelectedItemStyle";

	internal const string DataGrid_OnCancelCommand = "DataGrid_OnCancelCommand";

	internal const string DataGrid_OnDeleteCommand = "DataGrid_OnDeleteCommand";

	internal const string DataGrid_OnEditCommand = "DataGrid_OnEditCommand";

	internal const string DataGrid_OnItemCommand = "DataGrid_OnItemCommand";

	internal const string DataGrid_OnPageIndexChanged = "DataGrid_OnPageIndexChanged";

	internal const string DataGrid_OnSortCommand = "DataGrid_OnSortCommand";

	internal const string DataGrid_OnUpdateCommand = "DataGrid_OnUpdateCommand";

	internal const string DataGrid_VisibleItemCount = "DataGrid_VisibleItemCount";

	internal const string DataGridColumn_FooterStyle = "DataGridColumn_FooterStyle";

	internal const string DataGridColumn_FooterText = "DataGridColumn_FooterText";

	internal const string DataGridColumn_HeaderImageUrl = "DataGridColumn_HeaderImageUrl";

	internal const string DataGridColumn_HeaderStyle = "DataGridColumn_HeaderStyle";

	internal const string DataGridColumn_HeaderText = "DataGridColumn_HeaderText";

	internal const string DataGridColumn_ItemStyle = "DataGridColumn_ItemStyle";

	internal const string DataGridColumn_SortExpression = "DataGridColumn_SortExpression";

	internal const string DataGridColumn_Visible = "DataGridColumn_Visible";

	internal const string DataGridPagerStyle_Mode = "DataGridPagerStyle_Mode";

	internal const string DataGridPagerStyle_PageButtonCount = "DataGridPagerStyle_PageButtonCount";

	internal const string DataGridPagerStyle_Position = "DataGridPagerStyle_Position";

	internal const string DataGridPagerStyle_Visible = "DataGridPagerStyle_Visible";

	internal const string DataList_AlternatingItemStyle = "DataList_AlternatingItemStyle";

	internal const string DataList_AlternatingItemTemplate = "DataList_AlternatingItemTemplate";

	internal const string DataList_EditItemIndex = "DataList_EditItemIndex";

	internal const string DataList_EditItemStyle = "DataList_EditItemStyle";

	internal const string DataList_EditItemTemplate = "DataList_EditItemTemplate";

	internal const string DataList_ExtractTemplateRows = "DataList_ExtractTemplateRows";

	internal const string DataList_FooterTemplate = "DataList_FooterTemplate";

	internal const string DataList_HeaderTemplate = "DataList_HeaderTemplate";

	internal const string DataList_ItemStyle = "DataList_ItemStyle";

	internal const string DataList_Items = "DataList_Items";

	internal const string DataList_ItemTemplate = "DataList_ItemTemplate";

	internal const string DataList_RepeatColumns = "DataList_RepeatColumns";

	internal const string DataList_SelectedItemStyle = "DataList_SelectedItemStyle";

	internal const string DataList_SelectedItem = "DataList_SelectedItem";

	internal const string DataList_SelectedItemTemplate = "DataList_SelectedItemTemplate";

	internal const string DataList_SeparatorStyle = "DataList_SeparatorStyle";

	internal const string DataList_SeparatorTemplate = "DataList_SeparatorTemplate";

	internal const string DataList_OnCancelCommand = "DataList_OnCancelCommand";

	internal const string DataList_OnDeleteCommand = "DataList_OnDeleteCommand";

	internal const string DataList_OnEditCommand = "DataList_OnEditCommand";

	internal const string DataList_OnItemCommand = "DataList_OnItemCommand";

	internal const string DataList_OnUpdateCommand = "DataList_OnUpdateCommand";

	internal const string DetailsView_AllowPaging = "DetailsView_AllowPaging";

	internal const string DetailsView_AlternatingRowStyle = "DetailsView_AlternatingRowStyle";

	internal const string DetailsView_AutoGenerateDeleteButton = "DetailsView_AutoGenerateDeleteButton";

	internal const string DetailsView_AutoGenerateEditButton = "DetailsView_AutoGenerateEditButton";

	internal const string DetailsView_AutoGenerateInsertButton = "DetailsView_AutoGenerateInsertButton";

	internal const string DetailsView_AutoGenerateRows = "DetailsView_AutoGenerateRows";

	internal const string DetailsView_CellPadding = "DetailsView_CellPadding";

	internal const string DetailsView_CellSpacing = "DetailsView_CellSpacing";

	internal const string DetailsView_CommandRowStyle = "DetailsView_CommandRowStyle";

	internal const string DetailsView_DataKey = "DetailsView_DataKey";

	internal const string DetailsView_PageIndex = "DetailsView_PageIndex";

	internal const string DetailsView_EnablePagingCallbacks = "DetailsView_EnablePagingCallbacks";

	internal const string DetailsView_FooterStyle = "DetailsView_FooterStyle";

	internal const string DetailsView_FooterTemplate = "DetailsView_FooterTemplate";

	internal const string DetailsView_FieldHeaderStyle = "DetailsView_FieldHeaderStyle";

	internal const string DetailsView_OnPageIndexChanged = "DetailsView_OnPageIndexChanged";

	internal const string DetailsView_OnPageIndexChanging = "DetailsView_OnPageIndexChanging";

	internal const string DetailsView_OnItemCommand = "DetailsView_OnItemCommand";

	internal const string DetailsView_OnItemCreated = "DetailsView_OnItemCreated";

	internal const string DetailsView_OnModeChanged = "DetailsView_OnModeChanged";

	internal const string DetailsView_OnModeChanging = "DetailsView_OnModeChanging";

	internal const string DetailsView_PagerSettings = "DetailsView_PagerSettings";

	internal const string DetailsView_Fields = "DetailsView_Fields";

	internal const string DetailsView_Rows = "DetailsView_Rows";

	internal const string FontInfo_Name = "FontInfo_Name";

	internal const string FontInfo_Names = "FontInfo_Names";

	internal const string FontInfo_Size = "FontInfo_Size";

	internal const string FontInfo_Bold = "FontInfo_Bold";

	internal const string FontInfo_Italic = "FontInfo_Italic";

	internal const string FontInfo_Underline = "FontInfo_Underline";

	internal const string FontInfo_Strikeout = "FontInfo_Strikeout";

	internal const string FontInfo_Overline = "FontInfo_Overline";

	internal const string FormView_AllowPaging = "FormView_AllowPaging";

	internal const string FormView_CellPadding = "FormView_CellPadding";

	internal const string FormView_CellSpacing = "FormView_CellSpacing";

	internal const string FormView_DataKey = "FormView_DataKey";

	internal const string FormView_PageIndex = "FormView_PageIndex";

	internal const string FormView_EditItemTemplate = "FormView_EditItemTemplate";

	internal const string FormView_RenderOuterTable = "FormView_RenderOuterTable";

	internal const string FormView_FooterStyle = "FormView_FooterStyle";

	internal const string FormView_FooterTemplate = "FormView_FooterTemplate";

	internal const string FormView_InsertItemTemplate = "FormView_InsertItemTemplate";

	internal const string FormView_OnPageIndexChanged = "FormView_OnPageIndexChanged";

	internal const string FormView_OnPageIndexChanging = "FormView_OnPageIndexChanging";

	internal const string FormView_OnItemCommand = "FormView_OnItemCommand";

	internal const string FormView_OnItemCreated = "FormView_OnItemCreated";

	internal const string FormView_OnModeChanged = "FormView_OnModeChanged";

	internal const string FormView_OnModeChanging = "FormView_OnModeChanging";

	internal const string FormView_Rows = "FormView_Rows";

	internal const string HiddenField_OnValueChanged = "HiddenField_OnValueChanged";

	internal const string HiddenField_Value = "HiddenField_Value";

	internal const string HotSpot_AccessKey = "HotSpot_AccessKey";

	internal const string HotSpot_AlternateText = "HotSpot_AlternateText";

	internal const string HotSpot_PostBackValue = "HotSpot_PostBackValue";

	internal const string HotSpot_NavigateUrl = "HotSpot_NavigateUrl";

	internal const string HotSpot_TabIndex = "HotSpot_TabIndex";

	internal const string HyperLink_ImageUrl = "HyperLink_ImageUrl";

	internal const string HyperLink_ImageHeight = "HyperLink_ImageHeight";

	internal const string HyperLink_ImageWidth = "HyperLink_ImageWidth";

	internal const string HyperLink_NavigateUrl = "HyperLink_NavigateUrl";

	internal const string HyperLink_Target = "HyperLink_Target";

	internal const string HyperLink_Text = "HyperLink_Text";

	internal const string HyperLinkColumn_DataNavigateUrlField = "HyperLinkColumn_DataNavigateUrlField";

	internal const string HyperLinkColumn_DataTextField = "HyperLinkColumn_DataTextField";

	internal const string HyperLinkColumn_NavigateUrl = "HyperLinkColumn_NavigateUrl";

	internal const string HyperLinkColumn_Text = "HyperLinkColumn_Text";

	internal const string HyperLinkField_DataNavigateUrlFields = "HyperLinkField_DataNavigateUrlFields";

	internal const string HyperLinkField_DataNavigateUrlFormatString = "HyperLinkField_DataNavigateUrlFormatString";

	internal const string HyperLinkField_DataTextField = "HyperLinkField_DataTextField";

	internal const string HyperLinkField_DataTextFormatString = "HyperLinkField_DataTextFormatString";

	internal const string HyperLinkField_NavigateUrl = "HyperLinkField_NavigateUrl";

	internal const string HyperLinkField_Text = "HyperLinkField_Text";

	internal const string Image_AlternateText = "Image_AlternateText";

	internal const string Image_DescriptionUrl = "Image_DescriptionUrl";

	internal const string Image_GenerateEmptyAlternateText = "Image_GenerateEmptyAlternateText";

	internal const string Image_ImageAlign = "Image_ImageAlign";

	internal const string Image_ImageUrl = "Image_ImageUrl";

	internal const string ImageButton_OnClick = "ImageButton_OnClick";

	internal const string ImageButton_OnCommand = "ImageButton_OnCommand";

	internal const string ImageField_AlternateText = "ImageField_AlternateText";

	internal const string ImageField_DataAlternateTextField = "ImageField_DataAlternateTextField";

	internal const string ImageField_DataAlternateTextFormatString = "ImageField_DataAlternateTextFormatString";

	internal const string ImageField_ConvertEmptyStringToNull = "ImageField_ConvertEmptyStringToNull";

	internal const string ImageField_ImageUrlField = "ImageField_ImageUrlField";

	internal const string ImageField_ImageUrlFormatString = "ImageField_ImageUrlFormatString";

	internal const string ImageField_NullImageUrl = "ImageField_NullImageUrl";

	internal const string ImageField_ReadOnly = "ImageField_ReadOnly";

	internal const string ImageMap_Click = "ImageMap_Click";

	internal const string ImageMap_HotSpots = "ImageMap_HotSpots";

	internal const string IRenderOuterTableControl_CannotSetStyleWhenDisableRenderOuterTable = "IRenderOuterTableControl_CannotSetStyleWhenDisableRenderOuterTable";

	internal const string Label_AssociatedControlID = "Label_AssociatedControlID";

	internal const string Label_Text = "Label_Text";

	internal const string Literal_Text = "Literal_Text";

	internal const string Literal_Mode = "Literal_Mode";

	internal const string LinkButton_Text = "LinkButton_Text";

	internal const string LinkButton_OnClick = "LinkButton_OnClick";

	internal const string ListBox_Rows = "ListBox_Rows";

	internal const string ListBox_SelectionMode = "ListBox_SelectionMode";

	internal const string ListControl_AppendDataBoundItems = "ListControl_AppendDataBoundItems";

	internal const string ListControl_AutoPostBack = "ListControl_AutoPostBack";

	internal const string ListControl_DataTextField = "ListControl_DataTextField";

	internal const string ListControl_DataTextFormatString = "ListControl_DataTextFormatString";

	internal const string ListControl_DataValueField = "ListControl_DataValueField";

	internal const string ListControl_Items = "ListControl_Items";

	internal const string ListControl_SelectedItem = "ListControl_SelectedItem";

	internal const string ListControl_SelectedValue = "ListControl_SelectedValue";

	internal const string ListControl_OnSelectedIndexChanged = "ListControl_OnSelectedIndexChanged";

	internal const string ListControl_Text = "ListControl_Text";

	internal const string ListControl_TextChanged = "ListControl_TextChanged";

	internal const string Login_LoggedIn = "Login_LoggedIn";

	internal const string Login_Authenticate = "Login_Authenticate";

	internal const string Login_LoggingIn = "Login_LoggingIn";

	internal const string Login_CheckBoxStyle = "Login_CheckBoxStyle";

	internal const string Login_CreateUserUrl = "Login_CreateUserUrl";

	internal const string Login_CreateUserIconUrl = "Login_CreateUserIconUrl";

	internal const string Login_DefaultFailureText = "Login_DefaultFailureText";

	internal const string LoginControls_DefaultPasswordLabelText = "LoginControls_DefaultPasswordLabelText";

	internal const string Login_DefaultPasswordRequiredErrorMessage = "Login_DefaultPasswordRequiredErrorMessage";

	internal const string Login_DefaultRememberMeText = "Login_DefaultRememberMeText";

	internal const string Login_DefaultLoginButtonText = "Login_DefaultLoginButtonText";

	internal const string Login_DefaultTitleText = "Login_DefaultTitleText";

	internal const string Login_DefaultUserNameLabelText = "Login_DefaultUserNameLabelText";

	internal const string Login_DefaultUserNameRequiredErrorMessage = "Login_DefaultUserNameRequiredErrorMessage";

	internal const string Login_DestinationPageUrl = "Login_DestinationPageUrl";

	internal const string Login_DisplayRememberMe = "Login_DisplayRememberMe";

	internal const string Login_HelpPageIconUrl = "Login_HelpPageIconUrl";

	internal const string Login_InvalidBorderPadding = "Login_InvalidBorderPadding";

	internal const string Login_LoginError = "Login_LoginError";

	internal const string Login_FailureAction = "Login_FailureAction";

	internal const string Login_FailureText = "Login_FailureText";

	internal const string Login_Orientation = "Login_Orientation";

	internal const string Login_NoPasswordTextBox = "Login_NoPasswordTextBox";

	internal const string Login_NoUserNameTextBox = "Login_NoUserNameTextBox";

	internal const string LoginControls_PasswordLabelText = "LoginControls_PasswordLabelText";

	internal const string Login_PasswordRecoveryUrl = "Login_PasswordRecoveryUrl";

	internal const string Login_PasswordRecoveryIconUrl = "Login_PasswordRecoveryIconUrl";

	internal const string Login_PasswordRequiredErrorMessage = "Login_PasswordRequiredErrorMessage";

	internal const string Login_RememberMeSet = "Login_RememberMeSet";

	internal const string Login_RememberMeText = "Login_RememberMeText";

	internal const string LoginControls_RenderOuterTable = "LoginControls_RenderOuterTable";

	internal const string Login_LoginButtonImageUrl = "Login_LoginButtonImageUrl";

	internal const string Login_LoginButtonStyle = "Login_LoginButtonStyle";

	internal const string Login_LoginButtonType = "Login_LoginButtonType";

	internal const string Login_LoginButtonText = "Login_LoginButtonText";

	internal const string Login_BorderPadding = "Login_BorderPadding";

	internal const string Login_ValidatorTextStyle = "Login_ValidatorTextStyle";

	internal const string Login_VisibleWhenLoggedIn = "Login_VisibleWhenLoggedIn";

	internal const string LoginName_InvalidFormatString = "LoginName_InvalidFormatString";

	internal const string LoginName_FormatString = "LoginName_FormatString";

	internal const string LoginName_DesignModeUserName = "LoginName_DesignModeUserName";

	internal const string LoginStatus_LoginImageUrl = "LoginStatus_LoginImageUrl";

	internal const string LoginStatus_LoginText = "LoginStatus_LoginText";

	internal const string LoginStatus_LogoutAction = "LoginStatus_LogoutAction";

	internal const string LoginStatus_LogoutImageUrl = "LoginStatus_LogoutImageUrl";

	internal const string LoginStatus_LogoutPageUrl = "LoginStatus_LogoutPageUrl";

	internal const string LoginStatus_LogoutText = "LoginStatus_LogoutText";

	internal const string LoginStatus_LoggedOut = "LoginStatus_LoggedOut";

	internal const string LoginStatus_LoggingOut = "LoginStatus_LoggingOut";

	internal const string LoginStatus_DefaultLoginText = "LoginStatus_DefaultLoginText";

	internal const string LoginStatus_DefaultLogoutText = "LoginStatus_DefaultLogoutText";

	internal const string LoginView_RoleGroups = "LoginView_RoleGroups";

	internal const string LoginView_ViewChanged = "LoginView_ViewChanged";

	internal const string LoginView_ViewChanging = "LoginView_ViewChanging";

	internal const string EmbeddedMailObject_Name = "EmbeddedMailObject_Name";

	internal const string EmbeddedMailObject_Path = "EmbeddedMailObject_Path";

	internal const string MailDefinition_EmbeddedObjects = "MailDefinition_EmbeddedObjects";

	internal const string MailDefinition_BodyFileName = "MailDefinition_BodyFileName";

	internal const string MailDefinition_CC = "MailDefinition_CC";

	internal const string MailDefinition_From = "MailDefinition_From";

	internal const string MailDefinition_InvalidReplacements = "MailDefinition_InvalidReplacements";

	internal const string MailDefinition_IsBodyHtml = "MailDefinition_IsBodyHtml";

	internal const string MailDefinition_NoFromAddressSpecified = "MailDefinition_NoFromAddressSpecified";

	internal const string MailDefinition_Priority = "MailDefinition_Priority";

	internal const string MailDefinition_Subject = "MailDefinition_Subject";

	internal const string MenuItemStyle_HorizontalPadding = "MenuItemStyle_HorizontalPadding";

	internal const string MenuItemStyle_ItemSpacing = "MenuItemStyle_ItemSpacing";

	internal const string MenuItemStyle_VerticalPadding = "MenuItemStyle_VerticalPadding";

	internal const string MenuItemStyleCollection_InvalidArgument = "MenuItemStyleCollection_InvalidArgument";

	internal const string MenuItemBinding_Depth = "MenuItemBinding_Depth";

	internal const string MenuItemBinding_Enabled = "MenuItemBinding_Enabled";

	internal const string MenuItemBinding_EnabledField = "MenuItemBinding_EnabledField";

	internal const string MenuItemBinding_FormatString = "MenuItemBinding_FormatString";

	internal const string MenuItemBinding_ImageUrl = "MenuItemBinding_ImageUrl";

	internal const string MenuItemBinding_ImageUrlField = "MenuItemBinding_ImageUrlField";

	internal const string MenuItemBinding_NavigateUrl = "MenuItemBinding_NavigateUrl";

	internal const string MenuItemBinding_NavigateUrlField = "MenuItemBinding_NavigateUrlField";

	internal const string MenuItemBinding_PopOutImageUrl = "MenuItemBinding_PopOutImageUrl";

	internal const string MenuItemBinding_PopOutImageUrlField = "MenuItemBinding_PopOutImageUrlField";

	internal const string MenuItemBinding_Selectable = "MenuItemBinding_Selectable";

	internal const string MenuItemBinding_SelectableField = "MenuItemBinding_SelectableField";

	internal const string MenuItemBinding_SeparatorImageUrl = "MenuItemBinding_SeparatorImageUrl";

	internal const string MenuItemBinding_SeparatorImageUrlField = "MenuItemBinding_SeparatorImageUrlField";

	internal const string MenuItemBinding_Target = "MenuItemBinding_Target";

	internal const string MenuItemBinding_TargetField = "MenuItemBinding_TargetField";

	internal const string MenuItemBinding_Text = "MenuItemBinding_Text";

	internal const string MenuItemBinding_TextField = "MenuItemBinding_TextField";

	internal const string MenuItemBinding_ToolTip = "MenuItemBinding_ToolTip";

	internal const string MenuItemBinding_ToolTipField = "MenuItemBinding_ToolTipField";

	internal const string MenuItemBinding_Value = "MenuItemBinding_Value";

	internal const string MenuItemBinding_ValueField = "MenuItemBinding_ValueField";

	internal const string MenuItem_Enabled = "MenuItem_Enabled";

	internal const string MenuItem_ImageUrl = "MenuItem_ImageUrl";

	internal const string MenuItem_NavigateUrl = "MenuItem_NavigateUrl";

	internal const string MenuItem_PopOutImageUrl = "MenuItem_PopOutImageUrl";

	internal const string MenuItem_Selectable = "MenuItem_Selectable";

	internal const string MenuItem_Selected = "MenuItem_Selected";

	internal const string MenuItem_SeparatorImageUrl = "MenuItem_SeparatorImageUrl";

	internal const string MenuItem_Target = "MenuItem_Target";

	internal const string MenuItem_Text = "MenuItem_Text";

	internal const string MenuItem_ToolTip = "MenuItem_ToolTip";

	internal const string MenuItem_Value = "MenuItem_Value";

	internal const string MenuItemCollection_InvalidArrayType = "MenuItemCollection_InvalidArrayType";

	internal const string Menu_Bindings = "Menu_Bindings";

	internal const string Menu_CannotChangeRenderingMode = "Menu_CannotChangeRenderingMode";

	internal const string Menu_DataSourceReturnedNullView = "Menu_DataSourceReturnedNullView";

	internal const string Menu_DesignTimeDummyItemText = "Menu_DesignTimeDummyItemText";

	internal const string Menu_DisappearAfter = "Menu_DisappearAfter";

	internal const string Menu_DynamicBottomSeparatorImageUrl = "Menu_DynamicBottomSeparatorImageUrl";

	internal const string Menu_DynamicDisplayPopOutImage = "Menu_DynamicDisplayPopOutImage";

	internal const string Menu_DynamicHorizontalOffset = "Menu_DynamicHorizontalOffset";

	internal const string Menu_DynamicHoverStyle = "Menu_DynamicHoverStyle";

	internal const string Menu_DynamicItemFormatString = "Menu_DynamicItemFormatString";

	internal const string Menu_DynamicMenuItemStyle = "Menu_DynamicMenuItemStyle";

	internal const string Menu_DynamicMenuStyle = "Menu_DynamicMenuStyle";

	internal const string Menu_DynamicPopoutImageUrl = "Menu_DynamicPopoutImageUrl";

	internal const string Menu_DynamicPopoutImageText = "Menu_DynamicPopoutImageText";

	internal const string Menu_DynamicSelectedStyle = "Menu_DynamicSelectedStyle";

	internal const string Menu_DynamicTemplate = "Menu_DynamicTemplate";

	internal const string Menu_DynamicTopSeparatorImageUrl = "Menu_DynamicTopSeparatorImageUrl";

	internal const string Menu_DynamicVerticalOffset = "Menu_DynamicVerticalOffset";

	internal const string Menu_IncludeStyleBlock = "Menu_IncludeStyleBlock";

	internal const string Menu_InvalidDataBinding = "Menu_InvalidDataBinding";

	internal const string Menu_InvalidDepth = "Menu_InvalidDepth";

	internal const string Menu_InvalidNavigation = "Menu_InvalidNavigation";

	internal const string Menu_InvalidSelection = "Menu_InvalidSelection";

	internal const string Menu_Items = "Menu_Items";

	internal const string Menu_ItemWrap = "Menu_ItemWrap";

	internal const string Menu_LevelMenuItemStyles = "Menu_LevelMenuItemStyles";

	internal const string Menu_LevelSelectedStyles = "Menu_LevelSelectedStyles";

	internal const string Menu_LevelSubMenuStyles = "Menu_LevelSubMenuStyles";

	internal const string Menu_MaximumDynamicDisplayLevels = "Menu_MaximumDynamicDisplayLevels";

	internal const string Menu_MaximumDynamicDisplayLevelsInvalid = "Menu_MaximumDynamicDisplayLevelsInvalid";

	internal const string Menu_MenuItemClick = "Menu_MenuItemClick";

	internal const string Menu_MenuItemDataBound = "Menu_MenuItemDataBound";

	internal const string Menu_Orientation = "Menu_Orientation";

	internal const string Menu_PathSeparator = "Menu_PathSeparator";

	internal const string Menu_RenderingMode = "Menu_RenderingMode";

	internal const string Menu_ScrollDown = "Menu_ScrollDown";

	internal const string Menu_ScrollDownImageUrl = "Menu_ScrollDownImageUrl";

	internal const string Menu_ScrollDownText = "Menu_ScrollDownText";

	internal const string Menu_ScrollUpImageUrl = "Menu_ScrollUpImageUrl";

	internal const string Menu_SkipLinkTextDefault = "Menu_SkipLinkTextDefault";

	internal const string Menu_ScrollUp = "Menu_ScrollUp";

	internal const string Menu_ScrollUpText = "Menu_ScrollUpText";

	internal const string Menu_StaticBottomSeparatorImageUrl = "Menu_StaticBottomSeparatorImageUrl";

	internal const string Menu_StaticDisplayLevels = "Menu_StaticDisplayLevels";

	internal const string Menu_StaticDisplayPopOutImage = "Menu_StaticDisplayPopOutImage";

	internal const string Menu_StaticHoverStyle = "Menu_StaticHoverStyle";

	internal const string Menu_StaticItemFormatString = "Menu_StaticItemFormatString";

	internal const string Menu_StaticMenuItemStyle = "Menu_StaticMenuItemStyle";

	internal const string Menu_StaticMenuStyle = "Menu_StaticMenuStyle";

	internal const string Menu_StaticPopoutImageText = "Menu_StaticPopoutImageText";

	internal const string Menu_StaticPopoutImageUrl = "Menu_StaticPopoutImageUrl";

	internal const string Menu_StaticSelectedStyle = "Menu_StaticSelectedStyle";

	internal const string Menu_StaticSubMenuIndent = "Menu_StaticSubMenuIndent";

	internal const string Menu_StaticTemplate = "Menu_StaticTemplate";

	internal const string Menu_StaticTopSeparatorImageUrl = "Menu_StaticTopSeparatorImageUrl";

	internal const string ModelErrorMessage_AssociatedControlID = "ModelErrorMessage_AssociatedControlID";

	internal const string ModelErrorMessage_ModelStateKey = "ModelErrorMessage_ModelStateKey";

	internal const string ModelErrorMessage_SetFocusOnError = "ModelErrorMessage_SetFocusOnError";

	internal const string MultiView_ActiveView = "MultiView_ActiveView";

	internal const string MultiView_ActiveViewChanged = "MultiView_ActiveViewChanged";

	internal const string MultiView_ActiveViewIndex_out_of_range = "MultiView_ActiveViewIndex_out_of_range";

	internal const string MultiView_cannot_have_children_of_type = "MultiView_cannot_have_children_of_type";

	internal const string Multiview_rendering_block_not_allowed = "Multiview_rendering_block_not_allowed";

	internal const string MultiView_Views = "MultiView_Views";

	internal const string MultiView_invalid_view_id = "MultiView_invalid_view_id";

	internal const string MultiView_invalid_view_index_format = "MultiView_invalid_view_index_format";

	internal const string MultiView_view_not_found = "MultiView_view_not_found";

	internal const string MultiView_ActiveViewIndex_less_than_minus_one = "MultiView_ActiveViewIndex_less_than_minus_one";

	internal const string MultiView_ActiveViewIndex_equal_or_greater_than_count = "MultiView_ActiveViewIndex_equal_or_greater_than_count";

	internal const string View_CannotSetVisible = "View_CannotSetVisible";

	internal const string SiteMapPath_CannotFindUrl = "SiteMapPath_CannotFindUrl";

	internal const string SiteMapPath_CurrentNodeStyle = "SiteMapPath_CurrentNodeStyle";

	internal const string SiteMapPath_CurrentNodeTemplate = "SiteMapPath_CurrentNodeTemplate";

	internal const string SiteMapPath_OnItemDataBound = "SiteMapPath_OnItemDataBound";

	internal const string SiteMapPath_NodeStyle = "SiteMapPath_NodeStyle";

	internal const string SiteMapPath_NodeTemplate = "SiteMapPath_NodeTemplate";

	internal const string SiteMapPath_PathDirection = "SiteMapPath_PathDirection";

	internal const string SiteMapPath_PathSeparator = "SiteMapPath_PathSeparator";

	internal const string SiteMapPath_PathSeparatorTemplate = "SiteMapPath_PathSeparatorTemplate";

	internal const string SiteMapPath_PathSeparatorStyle = "SiteMapPath_PathSeparatorStyle";

	internal const string SiteMapPath_Provider = "SiteMapPath_Provider";

	internal const string SiteMapPath_RenderCurrentNodeAsLink = "SiteMapPath_RenderCurrentNodeAsLink";

	internal const string SiteMapPath_RootNodeStyle = "SiteMapPath_RootNodeStyle";

	internal const string SiteMapPath_RootNodeTemplate = "SiteMapPath_RootNodeTemplate";

	internal const string SiteMapPath_SiteMapProvider = "SiteMapPath_SiteMapProvider";

	internal const string SiteMapPath_SkipToContentText = "SiteMapPath_SkipToContentText";

	internal const string SiteMapPath_Default_SkipToContentText = "SiteMapPath_Default_SkipToContentText";

	internal const string SiteMapPath_ShowToolTips = "SiteMapPath_ShowToolTips";

	internal const string SiteMapPath_ParentLevelsDisplayed = "SiteMapPath_ParentLevelsDisplayed";

	internal const string SubMenuStyle_HorizontalPadding = "SubMenuStyle_HorizontalPadding";

	internal const string SubMenuStyle_VerticalPadding = "SubMenuStyle_VerticalPadding";

	internal const string SubMenuStyleCollection_InvalidArgument = "SubMenuStyleCollection_InvalidArgument";

	internal const string Panel_BackImageUrl = "Panel_BackImageUrl";

	internal const string Panel_DefaultButton = "Panel_DefaultButton";

	internal const string Panel_Direction = "Panel_Direction";

	internal const string Panel_GroupingText = "Panel_GroupingText";

	internal const string Panel_HorizontalAlign = "Panel_HorizontalAlign";

	internal const string Panel_ScrollBars = "Panel_ScrollBars";

	internal const string Panel_Wrap = "Panel_Wrap";

	internal const string PasswordRecovery_AnswerLabelText = "PasswordRecovery_AnswerLabelText";

	internal const string PasswordRecovery_AnswerLookupError = "PasswordRecovery_AnswerLookupError";

	internal const string PasswordRecovery_VerifyingAnswer = "PasswordRecovery_VerifyingAnswer";

	internal const string PasswordRecovery_SendingMail = "PasswordRecovery_SendingMail";

	internal const string PasswordRecovery_VerifyingUser = "PasswordRecovery_VerifyingUser";

	internal const string PasswordRecovery_DefaultAnswerLabelText = "PasswordRecovery_DefaultAnswerLabelText";

	internal const string PasswordRecovery_DefaultAnswerRequiredErrorMessage = "PasswordRecovery_DefaultAnswerRequiredErrorMessage";

	internal const string PasswordRecovery_DefaultBody = "PasswordRecovery_DefaultBody";

	internal const string PasswordRecovery_DefaultGeneralFailureText = "PasswordRecovery_DefaultGeneralFailureText";

	internal const string PasswordRecovery_DefaultUserNameFailureText = "PasswordRecovery_DefaultUserNameFailureText";

	internal const string PasswordRecovery_DefaultQuestionInstructionText = "PasswordRecovery_DefaultQuestionInstructionText";

	internal const string PasswordRecovery_DefaultQuestionFailureText = "PasswordRecovery_DefaultQuestionFailureText";

	internal const string PasswordRecovery_DefaultQuestionLabelText = "PasswordRecovery_DefaultQuestionLabelText";

	internal const string PasswordRecovery_DefaultQuestionTitleText = "PasswordRecovery_DefaultQuestionTitleText";

	internal const string PasswordRecovery_DefaultSubject = "PasswordRecovery_DefaultSubject";

	internal const string PasswordRecovery_DefaultSubmitButtonText = "PasswordRecovery_DefaultSubmitButtonText";

	internal const string PasswordRecovery_DefaultSuccessText = "PasswordRecovery_DefaultSuccessText";

	internal const string PasswordRecovery_DefaultUserNameInstructionText = "PasswordRecovery_DefaultUserNameInstructionText";

	internal const string PasswordRecovery_DefaultUserNameLabelText = "PasswordRecovery_DefaultUserNameLabelText";

	internal const string PasswordRecovery_DefaultUserNameRequiredErrorMessage = "PasswordRecovery_DefaultUserNameRequiredErrorMessage";

	internal const string PasswordRecovery_DefaultUserNameTitleText = "PasswordRecovery_DefaultUserNameTitleText";

	internal const string PasswordRecovery_GeneralFailureText = "PasswordRecovery_GeneralFailureText";

	internal const string PasswordRecovery_InvalidBorderPadding = "PasswordRecovery_InvalidBorderPadding";

	internal const string PasswordRecovery_MailDefinition = "PasswordRecovery_MailDefinition";

	internal const string PasswordRecovery_NoUserNameTextBox = "PasswordRecovery_NoUserNameTextBox";

	internal const string PasswordRecovery_NoAnswerTextBox = "PasswordRecovery_NoAnswerTextBox";

	internal const string PasswordRecovery_QuestionFailureText = "PasswordRecovery_QuestionFailureText";

	internal const string PasswordRecovery_QuestionInstructionText = "PasswordRecovery_QuestionInstructionText";

	internal const string PasswordRecovery_QuestionLabelText = "PasswordRecovery_QuestionLabelText";

	internal const string PasswordRecovery_QuestionTemplate = "PasswordRecovery_QuestionTemplate";

	internal const string PasswordRecovery_QuestionTemplateContainer = "PasswordRecovery_QuestionTemplateContainer";

	internal const string PasswordRecovery_QuestionTitleText = "PasswordRecovery_QuestionTitleText";

	internal const string PasswordRecovery_RecoveryNotSupported = "PasswordRecovery_RecoveryNotSupported";

	internal const string PasswordRecovery_SubmitButtonStyle = "PasswordRecovery_SubmitButtonStyle";

	internal const string PasswordRecovery_SubmitButtonType = "PasswordRecovery_SubmitButtonType";

	internal const string PasswordRecovery_SuccessTemplate = "PasswordRecovery_SuccessTemplate";

	internal const string PasswordRecovery_SuccessTemplateContainer = "PasswordRecovery_SuccessTemplateContainer";

	internal const string PasswordRecovery_SuccessText = "PasswordRecovery_SuccessText";

	internal const string PasswordRecovery_SuccessTextStyle = "PasswordRecovery_SuccessTextStyle";

	internal const string PasswordRecovery_UserLookupError = "PasswordRecovery_UserLookupError";

	internal const string PasswordRecovery_UserNameFailureText = "PasswordRecovery_UserNameFailureText";

	internal const string PasswordRecovery_UserNameInstructionText = "PasswordRecovery_UserNameInstructionText";

	internal const string PasswordRecovery_UserNameLabelText = "PasswordRecovery_UserNameLabelText";

	internal const string PasswordRecovery_UserNameTemplate = "PasswordRecovery_UserNameTemplate";

	internal const string PasswordRecovery_UserNameTemplateContainer = "PasswordRecovery_UserNameTemplateContainer";

	internal const string PasswordRecovery_UserNameTitleText = "PasswordRecovery_UserNameTitleText";

	internal const string PolygonHotSpot_Coordinates = "PolygonHotSpot_Coordinates";

	internal const string RadioButton_GroupName = "RadioButton_GroupName";

	internal const string RadioButtonList_CellPadding = "RadioButtonList_CellPadding";

	internal const string RadioButtonList_CellSpacing = "RadioButtonList_CellSpacing";

	internal const string RadioButtonList_RepeatColumns = "RadioButtonList_RepeatColumns";

	internal const string RangeValidator_MaximumValue = "RangeValidator_MaximumValue";

	internal const string RangeValidator_MinmumValue = "RangeValidator_MinmumValue";

	internal const string RangeValidator_Type = "RangeValidator_Type";

	internal const string ReadOnlyHierarchicalDataSourceView_CantAccessPathInEnumerable = "ReadOnlyHierarchicalDataSourceView_CantAccessPathInEnumerable";

	internal const string RectangleHotSpot_Bottom = "RectangleHotSpot_Bottom";

	internal const string RectangleHotSpot_Right = "RectangleHotSpot_Right";

	internal const string RectangleHotSpot_Top = "RectangleHotSpot_Top";

	internal const string RectangleHotSpot_Left = "RectangleHotSpot_Left";

	internal const string RegularExpressionValidator_ValidationExpression = "RegularExpressionValidator_ValidationExpression";

	internal const string Repeater_AlternatingItemTemplate = "Repeater_AlternatingItemTemplate";

	internal const string Repeater_DataMember = "Repeater_DataMember";

	internal const string Repeater_FooterTemplate = "Repeater_FooterTemplate";

	internal const string Repeater_Items = "Repeater_Items";

	internal const string Repeater_ItemTemplate = "Repeater_ItemTemplate";

	internal const string Repeater_OnItemCommand = "Repeater_OnItemCommand";

	internal const string Repeater_SeparatorTemplate = "Repeater_SeparatorTemplate";

	internal const string RepeatInfo_ListLayoutDoesNotSupportHeaderFooterSeparator = "RepeatInfo_ListLayoutDoesNotSupportHeaderFooterSeparator";

	internal const string RepeatInfo_ListLayoutOnlySupportsVerticalLayout = "RepeatInfo_ListLayoutOnlySupportsVerticalLayout";

	internal const string RepeatInfo_ListLayoutDoesNotSupportMultipleColumn = "RepeatInfo_ListLayoutDoesNotSupportMultipleColumn";

	internal const string RepeatInfo_ListLayoutDoesNotSupportImpliedOuterTable = "RepeatInfo_ListLayoutDoesNotSupportImpliedOuterTable";

	internal const string RequiredFieldValidator_InitialValue = "RequiredFieldValidator_InitialValue";

	internal const string SiteMapDataSource_Description = "SiteMapDataSource_Description";

	internal const string SiteMapDataSource_DisplayName = "SiteMapDataSource_DisplayName";

	internal const string SiteMapDataSource_Provider = "SiteMapDataSource_Provider";

	internal const string SiteMapDataSource_ContainsListCollection = "SiteMapDataSource_ContainsListCollection";

	internal const string SiteMapDataSource_StartingNodeOffset = "SiteMapDataSource_StartingNodeOffset";

	internal const string SiteMapDataSource_StartingNodeUrl = "SiteMapDataSource_StartingNodeUrl";

	internal const string SiteMapDataSource_SiteMapProvider = "SiteMapDataSource_SiteMapProvider";

	internal const string SiteMapDataSource_ProviderNotFound = "SiteMapDataSource_ProviderNotFound";

	internal const string SiteMapDataSource_DefaultProviderNotFound = "SiteMapDataSource_DefaultProviderNotFound";

	internal const string SiteMapDataSource_ShowStartingNode = "SiteMapDataSource_ShowStartingNode";

	internal const string SiteMapDataSource_StartFromCurrentNode = "SiteMapDataSource_StartFromCurrentNode";

	internal const string SiteMapDataSource_StartingNodeUrlAndStartFromcurrentNode_Defined = "SiteMapDataSource_StartingNodeUrlAndStartFromcurrentNode_Defined";

	internal const string GridView_AllowCustomPaging = "GridView_AllowCustomPaging";

	internal const string GridView_AllowPaging = "GridView_AllowPaging";

	internal const string GridView_AllowSorting = "GridView_AllowSorting";

	internal const string GridView_AlternatingRowStyle = "GridView_AlternatingRowStyle";

	internal const string GridView_AutoGenerateDeleteButton = "GridView_AutoGenerateDeleteButton";

	internal const string GridView_AutoGenerateEditButton = "GridView_AutoGenerateEditButton";

	internal const string GridView_AutoGenerateSelectButton = "GridView_AutoGenerateSelectButton";

	internal const string GridView_CellPadding = "GridView_CellPadding";

	internal const string GridView_CellSpacing = "GridView_CellSpacing";

	internal const string GridView_DataKeys = "GridView_DataKeys";

	internal const string GridView_EditIndex = "GridView_EditIndex";

	internal const string GridView_EditRowStyle = "GridView_EditRowStyle";

	internal const string GridView_EnableSortingAndPagingCallbacks = "GridView_EnableSortingAndPagingCallbacks";

	internal const string GridView_EnablePersistedSelection = "GridView_EnablePersistedSelection";

	internal const string GridView_EmptyDataRowStyle = "GridView_EmptyDataRowStyle";

	internal const string GridView_OnRowCancelingEdit = "GridView_OnRowCancelingEdit";

	internal const string GridView_OnRowEditing = "GridView_OnRowEditing";

	internal const string GridView_OnPageIndexChanging = "GridView_OnPageIndexChanging";

	internal const string GridView_OnPageIndexChanged = "GridView_OnPageIndexChanged";

	internal const string GridView_OnSelectedIndexChanged = "GridView_OnSelectedIndexChanged";

	internal const string GridView_OnSelectedIndexChanging = "GridView_OnSelectedIndexChanging";

	internal const string GridView_OnSorted = "GridView_OnSorted";

	internal const string GridView_OnSorting = "GridView_OnSorting";

	internal const string GridView_OnRowCommand = "GridView_OnRowCommand";

	internal const string GridView_OnRowCreated = "GridView_OnRowCreated";

	internal const string GridView_OnRowDataBound = "GridView_OnRowDataBound";

	internal const string GridView_PageCount = "GridView_PageCount";

	internal const string GridView_PageIndex = "GridView_PageIndex";

	internal const string GridView_PagerSettings = "GridView_PagerSettings";

	internal const string GridView_PageSize = "GridView_PageSize";

	internal const string GridView_RowHeaderColumn = "GridView_RowHeaderColumn";

	internal const string GridView_Rows = "GridView_Rows";

	internal const string GridView_ShowHeaderWhenEmpty = "GridView_ShowHeaderWhenEmpty";

	internal const string GridView_SelectedIndex = "GridView_SelectedIndex";

	internal const string GridView_SelectedRow = "GridView_SelectedRow";

	internal const string GridView_SelectedRowStyle = "GridView_SelectedRowStyle";

	internal const string GridView_SortDirection = "GridView_SortDirection";

	internal const string GridView_SortExpression = "GridView_SortExpression";

	internal const string GridView_SortedAscendingCellStyle = "GridView_SortedAscendingCellStyle";

	internal const string GridView_SortedDescendingCellStyle = "GridView_SortedDescendingCellStyle";

	internal const string GridView_SortedAscendingHeaderStyle = "GridView_SortedAscendingHeaderStyle";

	internal const string GridView_SortedDescendingHeaderStyle = "GridView_SortedDescendingHeaderStyle";

	internal const string GridView_VirtualItemCount = "GridView_VirtualItemCount";

	internal const string PagerSettings_FirstPageImageUrl = "PagerSettings_FirstPageImageUrl";

	internal const string PagerSettings_FirstPageText = "PagerSettings_FirstPageText";

	internal const string PagerSettings_LastPageImageUrl = "PagerSettings_LastPageImageUrl";

	internal const string PagerSettings_LastPageText = "PagerSettings_LastPageText";

	internal const string PagerSettings_Mode = "PagerSettings_Mode";

	internal const string PagerSettings_NextPageImageUrl = "PagerSettings_NextPageImageUrl";

	internal const string PagerSettings_PageButtonCount = "PagerSettings_PageButtonCount";

	internal const string PagerSettings_PreviousPageImageUrl = "PagerSettings_PreviousPageImageUrl";

	internal const string PagerStyle_Position = "PagerStyle_Position";

	internal const string PagerStyle_Visible = "PagerStyle_Visible";

	internal const string Style_BackColor = "Style_BackColor";

	internal const string Style_BorderColor = "Style_BorderColor";

	internal const string Style_BorderWidth = "Style_BorderWidth";

	internal const string Style_BorderStyle = "Style_BorderStyle";

	internal const string Style_CSSClass = "Style_CSSClass";

	internal const string Style_Font = "Style_Font";

	internal const string Style_ForeColor = "Style_ForeColor";

	internal const string Style_Height = "Style_Height";

	internal const string Style_Width = "Style_Width";

	internal const string Substitution_MethodNameDescr = "Substitution_MethodNameDescr";

	internal const string Substitution_CannotBeInCachedControl = "Substitution_CannotBeInCachedControl";

	internal const string Substitution_BadMethodName = "Substitution_BadMethodName";

	internal const string Substitution_NotAllowed = "Substitution_NotAllowed";

	internal const string Substitution_SiteNotAllowed = "Substitution_SiteNotAllowed";

	internal const string Table_SectionsMustBeInOrder = "Table_SectionsMustBeInOrder";

	internal const string Table_BackImageUrl = "Table_BackImageUrl";

	internal const string Table_Caption = "Table_Caption";

	internal const string Table_CellSpacing = "Table_CellSpacing";

	internal const string Table_CellPadding = "Table_CellPadding";

	internal const string Table_GridLines = "Table_GridLines";

	internal const string Table_HorizontalAlign = "Table_HorizontalAlign";

	internal const string Table_Rows = "Table_Rows";

	internal const string TableCell_AssociatedHeaderCellNotFound = "TableCell_AssociatedHeaderCellNotFound";

	internal const string TableCell_AssociatedHeaderCellID = "TableCell_AssociatedHeaderCellID";

	internal const string TableCell_ColumnSpan = "TableCell_ColumnSpan";

	internal const string TableCell_RowSpan = "TableCell_RowSpan";

	internal const string TableCell_Text = "TableCell_Text";

	internal const string TableCell_Wrap = "TableCell_Wrap";

	internal const string TableHeaderCell_AbbreviatedText = "TableHeaderCell_AbbreviatedText";

	internal const string TableHeaderCell_Scope = "TableHeaderCell_Scope";

	internal const string TableHeaderCell_CategoryText = "TableHeaderCell_CategoryText";

	internal const string TableItemStyle_Wrap = "TableItemStyle_Wrap";

	internal const string TableRow_Cells = "TableRow_Cells";

	internal const string TableRow_TableSection = "TableRow_TableSection";

	internal const string TableSectionStyle_Visible = "TableSectionStyle_Visible";

	internal const string TableStyle_BackImageUrl = "TableStyle_BackImageUrl";

	internal const string TableStyle_CellPadding = "TableStyle_CellPadding";

	internal const string TableStyle_CellSpacing = "TableStyle_CellSpacing";

	internal const string TableStyle_GridLines = "TableStyle_GridLines";

	internal const string TableStyle_InvalidCellSpacing = "TableStyle_InvalidCellSpacing";

	internal const string TableStyle_InvalidCellPadding = "TableStyle_InvalidCellPadding";

	internal const string TableStyle_HorizontalAlign = "TableStyle_HorizontalAlign";

	internal const string Control_Missing_Attribute = "Control_Missing_Attribute";

	internal const string TemplateColumn_EditItemTemplate = "TemplateColumn_EditItemTemplate";

	internal const string TemplateColumn_FooterTemplate = "TemplateColumn_FooterTemplate";

	internal const string TemplateColumn_HeaderTemplate = "TemplateColumn_HeaderTemplate";

	internal const string TemplateColumn_ItemTemplate = "TemplateColumn_ItemTemplate";

	internal const string TemplateField_AlternatingItemTemplate = "TemplateField_AlternatingItemTemplate";

	internal const string TemplateField_EditItemTemplate = "TemplateField_EditItemTemplate";

	internal const string TemplateField_FooterTemplate = "TemplateField_FooterTemplate";

	internal const string TemplateField_HeaderTemplate = "TemplateField_HeaderTemplate";

	internal const string TemplateField_InsertItemTemplate = "TemplateField_InsertItemTemplate";

	internal const string TemplateField_ItemTemplate = "TemplateField_ItemTemplate";

	internal const string TextBox_AutoCompleteType = "TextBox_AutoCompleteType";

	internal const string TextBox_AutoPostBack = "TextBox_AutoPostBack";

	internal const string TextBox_Columns = "TextBox_Columns";

	internal const string TextBox_InvalidColumns = "TextBox_InvalidColumns";

	internal const string TextBox_InvalidRows = "TextBox_InvalidRows";

	internal const string TextBox_MaxLength = "TextBox_MaxLength";

	internal const string TextBox_TextMode = "TextBox_TextMode";

	internal const string TextBox_ReadOnly = "TextBox_ReadOnly";

	internal const string TextBox_Rows = "TextBox_Rows";

	internal const string TextBox_Text = "TextBox_Text";

	internal const string TextBox_Wrap = "TextBox_Wrap";

	internal const string TextBox_OnTextChanged = "TextBox_OnTextChanged";

	internal const string TreeNodeStyle_ChildNodesPadding = "TreeNodeStyle_ChildNodesPadding";

	internal const string TreeNodeStyle_HorizontalPadding = "TreeNodeStyle_HorizontalPadding";

	internal const string TreeNodeStyle_ImageUrl = "TreeNodeStyle_ImageUrl";

	internal const string TreeNodeStyle_NodeSpacing = "TreeNodeStyle_NodeSpacing";

	internal const string TreeNodeStyle_VerticalPadding = "TreeNodeStyle_VerticalPadding";

	internal const string TreeNodeStyleCollection_InvalidArgument = "TreeNodeStyleCollection_InvalidArgument";

	internal const string TreeNodeBinding_Depth = "TreeNodeBinding_Depth";

	internal const string TreeNodeBinding_EmptyBindingText = "TreeNodeBinding_EmptyBindingText";

	internal const string TreeNodeBinding_FormatString = "TreeNodeBinding_FormatString";

	internal const string TreeNodeBinding_ImageToolTip = "TreeNodeBinding_ImageToolTip";

	internal const string TreeNodeBinding_ImageToolTipField = "TreeNodeBinding_ImageToolTipField";

	internal const string TreeNodeBinding_ImageUrl = "TreeNodeBinding_ImageUrl";

	internal const string TreeNodeBinding_ImageUrlField = "TreeNodeBinding_ImageUrlField";

	internal const string TreeNodeBinding_NavigateUrl = "TreeNodeBinding_NavigateUrl";

	internal const string TreeNodeBinding_NavigateUrlField = "TreeNodeBinding_NavigateUrlField";

	internal const string TreeNodeBinding_PopulateOnDemand = "TreeNodeBinding_PopulateOnDemand";

	internal const string TreeNodeBinding_SelectAction = "TreeNodeBinding_SelectAction";

	internal const string TreeNodeBinding_ShowCheckBox = "TreeNodeBinding_ShowCheckBox";

	internal const string TreeNodeBinding_Target = "TreeNodeBinding_Target";

	internal const string TreeNodeBinding_TargetField = "TreeNodeBinding_TargetField";

	internal const string TreeNodeBinding_Text = "TreeNodeBinding_Text";

	internal const string TreeNodeBinding_TextField = "TreeNodeBinding_TextField";

	internal const string TreeNodeBinding_ToolTip = "TreeNodeBinding_ToolTip";

	internal const string TreeNodeBinding_ToolTipField = "TreeNodeBinding_ToolTipField";

	internal const string TreeNodeBinding_Value = "TreeNodeBinding_Value";

	internal const string TreeNodeBinding_ValueField = "TreeNodeBinding_ValueField";

	internal const string TreeNodeCollection_InvalidArrayType = "TreeNodeCollection_InvalidArrayType";

	internal const string TreeNode_Checked = "TreeNode_Checked";

	internal const string TreeView_DataSourceReturnedNullView = "TreeView_DataSourceReturnedNullView";

	internal const string TreeNode_Expanded = "TreeNode_Expanded";

	internal const string TreeNode_ImageToolTip = "TreeNode_ImageToolTip";

	internal const string TreeNode_ImageUrl = "TreeNode_ImageUrl";

	internal const string TreeView_InvalidDataBinding = "TreeView_InvalidDataBinding";

	internal const string TreeNode_NavigateUrl = "TreeNode_NavigateUrl";

	internal const string TreeNode_PopulateOnDemand = "TreeNode_PopulateOnDemand";

	internal const string TreeView_PopulateOnlyForDataSourceControls = "TreeView_PopulateOnlyForDataSourceControls";

	internal const string TreeView_PopulateOnlyEmptyNodes = "TreeView_PopulateOnlyEmptyNodes";

	internal const string TreeNode_Selected = "TreeNode_Selected";

	internal const string TreeNode_SelectAction = "TreeNode_SelectAction";

	internal const string TreeNode_ShowCheckBox = "TreeNode_ShowCheckBox";

	internal const string TreeNode_Target = "TreeNode_Target";

	internal const string TreeNode_Text = "TreeNode_Text";

	internal const string TreeNode_ToolTip = "TreeNode_ToolTip";

	internal const string TreeNode_Value = "TreeNode_Value";

	internal const string TreeView_AutoGenerateDataBindings = "TreeView_AutoGenerateDataBindings";

	internal const string TreeView_DataBindings = "TreeView_DataBindings";

	internal const string TreeView_CollapseImageToolTip = "TreeView_CollapseImageToolTip";

	internal const string TreeView_CollapseImageToolTipDefaultValue = "TreeView_CollapseImageToolTipDefaultValue";

	internal const string TreeView_CollapseImageUrl = "TreeView_CollapseImageUrl";

	internal const string TreeView_Default_SkipLinkText = "TreeView_Default_SkipLinkText";

	internal const string TreeView_EnableClientScript = "TreeView_EnableClientScript";

	internal const string TreeView_ExpandImageToolTip = "TreeView_ExpandImageToolTip";

	internal const string TreeView_ExpandImageToolTipDefaultValue = "TreeView_ExpandImageToolTipDefaultValue";

	internal const string TreeView_ExpandImageUrl = "TreeView_ExpandImageUrl";

	internal const string TreeView_HoverNodeStyle = "TreeView_HoverNodeStyle";

	internal const string TreeView_ExpandDepth = "TreeView_ExpandDepth";

	internal const string TreeView_ImageSet = "TreeView_ImageSet";

	internal const string TreeView_LeafNodeStyle = "TreeView_LeafNodeStyle";

	internal const string TreeView_LevelStyles = "TreeView_LevelStyles";

	internal const string TreeView_LineImagesFolderUrl = "TreeView_LineImagesFolderUrl";

	internal const string TreeView_MaxDataBindDepth = "TreeView_MaxDataBindDepth";

	internal const string TreeView_NoExpandImageUrl = "TreeView_NoExpandImageUrl";

	internal const string TreeView_NodeIndent = "TreeView_NodeIndent";

	internal const string TreeView_Nodes = "TreeView_Nodes";

	internal const string TreeView_NodeStyle = "TreeView_NodeStyle";

	internal const string TreeView_NodeWrap = "TreeView_NodeWrap";

	internal const string TreeView_ParentNodeStyle = "TreeView_ParentNodeStyle";

	internal const string TreeView_PathSeparator = "TreeView_PathSeparator";

	internal const string TreeView_PopulateNodesFromClient = "TreeView_PopulateNodesFromClient";

	internal const string TreeView_RootNodeStyle = "TreeView_RootNodeStyle";

	internal const string TreeView_SelectedNodeStyle = "TreeView_SelectedNodeStyle";

	internal const string TreeView_ShowCheckBoxes = "TreeView_ShowCheckBoxes";

	internal const string TreeView_ShowExpandCollapse = "TreeView_ShowExpandCollapse";

	internal const string TreeView_ShowLines = "TreeView_ShowLines";

	internal const string TreeView_SkipLinkText = "TreeView_SkipLinkText";

	internal const string TreeView_CheckChanged = "TreeView_CheckChanged";

	internal const string TreeView_SelectedNodeChanged = "TreeView_SelectedNodeChanged";

	internal const string TreeView_TreeNodeCollapsed = "TreeView_TreeNodeCollapsed";

	internal const string TreeView_TreeNodeExpanded = "TreeView_TreeNodeExpanded";

	internal const string TreeView_TreeNodeDataBound = "TreeView_TreeNodeDataBound";

	internal const string TreeView_TreeNodePopulate = "TreeView_TreeNodePopulate";

	internal const string ValidationSummary_DisplayMode = "ValidationSummary_DisplayMode";

	internal const string ValidationSummary_HeaderText = "ValidationSummary_HeaderText";

	internal const string ValidationSummary_ShowMessageBox = "ValidationSummary_ShowMessageBox";

	internal const string ValidationSummary_ShowModelStateErrors = "ValidationSummary_ShowModelStateErrors";

	internal const string ValidationSummary_ShowSummary = "ValidationSummary_ShowSummary";

	internal const string ValidationSummary_ShowValidationErrors = "ValidationSummary_ShowValidationErrors";

	internal const string ValidationSummary_EnableClientScript = "ValidationSummary_EnableClientScript";

	internal const string ValidationSummary_ValidationGroup = "ValidationSummary_ValidationGroup";

	internal const string PostBackControl_ValidationGroup = "PostBackControl_ValidationGroup";

	internal const string AutoPostBackControl_CausesValidation = "AutoPostBackControl_CausesValidation";

	internal const string Calendar_Caption = "Calendar_Caption";

	internal const string Calendar_CellPadding = "Calendar_CellPadding";

	internal const string Calendar_CellSpacing = "Calendar_CellSpacing";

	internal const string Calendar_DayHeaderStyle = "Calendar_DayHeaderStyle";

	internal const string Calendar_DayNameFormat = "Calendar_DayNameFormat";

	internal const string Calendar_DayStyle = "Calendar_DayStyle";

	internal const string Calendar_FirstDayOfWeek = "Calendar_FirstDayOfWeek";

	internal const string Calendar_NextMonthText = "Calendar_NextMonthText";

	internal const string Calendar_NextPrevFormat = "Calendar_NextPrevFormat";

	internal const string Calendar_NextPrevStyle = "Calendar_NextPrevStyle";

	internal const string Calendar_OtherMonthDayStyle = "Calendar_OtherMonthDayStyle";

	internal const string Calendar_PrevMonthText = "Calendar_PrevMonthText";

	internal const string Calendar_SelectedDate = "Calendar_SelectedDate";

	internal const string Calendar_SelectedDates = "Calendar_SelectedDates";

	internal const string Calendar_SelectedDayStyle = "Calendar_SelectedDayStyle";

	internal const string Calendar_SelectionMode = "Calendar_SelectionMode";

	internal const string Calendar_SelectMonthText = "Calendar_SelectMonthText";

	internal const string Calendar_SelectorStyle = "Calendar_SelectorStyle";

	internal const string Calendar_SelectWeekText = "Calendar_SelectWeekText";

	internal const string Calendar_ShowDayHeader = "Calendar_ShowDayHeader";

	internal const string Calendar_ShowGridLines = "Calendar_ShowGridLines";

	internal const string Calendar_ShowNextPrevMonth = "Calendar_ShowNextPrevMonth";

	internal const string Calendar_ShowTitle = "Calendar_ShowTitle";

	internal const string Calendar_TitleFormat = "Calendar_TitleFormat";

	internal const string Calendar_TitleStyle = "Calendar_TitleStyle";

	internal const string Calendar_TodayDayStyle = "Calendar_TodayDayStyle";

	internal const string Calendar_TodaysDate = "Calendar_TodaysDate";

	internal const string Calendar_VisibleDate = "Calendar_VisibleDate";

	internal const string Calendar_WeekendDayStyle = "Calendar_WeekendDayStyle";

	internal const string Calendar_OnDayRender = "Calendar_OnDayRender";

	internal const string Calendar_OnSelectionChanged = "Calendar_OnSelectionChanged";

	internal const string Calendar_OnVisibleMonthChanged = "Calendar_OnVisibleMonthChanged";

	internal const string Calendar_TitleText = "Calendar_TitleText";

	internal const string Calendar_PreviousMonthTitle = "Calendar_PreviousMonthTitle";

	internal const string Calendar_NextMonthTitle = "Calendar_NextMonthTitle";

	internal const string Calendar_SelectMonthTitle = "Calendar_SelectMonthTitle";

	internal const string Calendar_SelectWeekTitle = "Calendar_SelectWeekTitle";

	internal const string View_Activate = "View_Activate";

	internal const string View_Deactivate = "View_Deactivate";

	internal const string ViewCollection_must_contain_view = "ViewCollection_must_contain_view";

	internal const string WebControl_AccessKey = "WebControl_AccessKey";

	internal const string WebControl_InvalidAccessKey = "WebControl_InvalidAccessKey";

	internal const string WebControl_Attributes = "WebControl_Attributes";

	internal const string WebControl_BackColor = "WebControl_BackColor";

	internal const string WebControl_BorderColor = "WebControl_BorderColor";

	internal const string WebControl_BorderWidth = "WebControl_BorderWidth";

	internal const string WebControl_BorderStyle = "WebControl_BorderStyle";

	internal const string WebControl_CSSClassName = "WebControl_CSSClassName";

	internal const string WebControl_ControlStyle = "WebControl_ControlStyle";

	internal const string WebControl_ControlStyleCreated = "WebControl_ControlStyleCreated";

	internal const string WebControl_Enabled = "WebControl_Enabled";

	internal const string WebControl_Font = "WebControl_Font";

	internal const string WebControl_ForeColor = "WebControl_ForeColor";

	internal const string WebControl_Height = "WebControl_Height";

	internal const string WebControl_Style = "WebControl_Style";

	internal const string WebControl_TabIndex = "WebControl_TabIndex";

	internal const string WebControl_Tooltip = "WebControl_Tooltip";

	internal const string WebControl_Width = "WebControl_Width";

	internal const string Wizard_ActiveStep = "Wizard_ActiveStep";

	internal const string Wizard_ActiveStepIndex = "Wizard_ActiveStepIndex";

	internal const string Wizard_ActiveStepIndex_out_of_range = "Wizard_ActiveStepIndex_out_of_range";

	internal const string Wizard_CancelButtonClick = "Wizard_CancelButtonClick";

	internal const string Wizard_CancelButtonImageUrl = "Wizard_CancelButtonImageUrl";

	internal const string Wizard_CancelButtonText = "Wizard_CancelButtonText";

	internal const string Wizard_CancelButtonType = "Wizard_CancelButtonType";

	internal const string Wizard_CancelButtonStyle = "Wizard_CancelButtonStyle";

	internal const string Wizard_CancelDestinationPageUrl = "Wizard_CancelDestinationPageUrl";

	internal const string Wizard_CellPadding = "Wizard_CellPadding";

	internal const string Wizard_CellSpacing = "Wizard_CellSpacing";

	internal const string Wizard_Default_CancelButtonText = "Wizard_Default_CancelButtonText";

	internal const string Wizard_DisplayCancelButton = "Wizard_DisplayCancelButton";

	internal const string Wizard_FinishDestinationPageUrl = "Wizard_FinishDestinationPageUrl";

	internal const string Wizard_FinishCompleteButtonStyle = "Wizard_FinishCompleteButtonStyle";

	internal const string Wizard_FinishCompleteButtonText = "Wizard_FinishCompleteButtonText";

	internal const string Wizard_FinishCompleteButtonType = "Wizard_FinishCompleteButtonType";

	internal const string Wizard_FinishCompleteButtonImageUrl = "Wizard_FinishCompleteButtonImageUrl";

	internal const string Wizard_FinishPreviousButtonStyle = "Wizard_FinishPreviousButtonStyle";

	internal const string Wizard_FinishPreviousButtonText = "Wizard_FinishPreviousButtonText";

	internal const string Wizard_FinishPreviousButtonType = "Wizard_FinishPreviousButtonType";

	internal const string Wizard_FinishPreviousButtonImageUrl = "Wizard_FinishPreviousButtonImageUrl";

	internal const string Wizard_FinishNavigationTemplate = "Wizard_FinishNavigationTemplate";

	internal const string Wizard_InvalidBubbleEvent = "Wizard_InvalidBubbleEvent";

	internal const string Wizard_NavigationButtonStyle = "Wizard_NavigationButtonStyle";

	internal const string Wizard_NavigationStyle = "Wizard_NavigationStyle";

	internal const string Wizard_StepNextButtonStyle = "Wizard_StepNextButtonStyle";

	internal const string Wizard_StepNextButtonText = "Wizard_StepNextButtonText";

	internal const string Wizard_StepNextButtonType = "Wizard_StepNextButtonType";

	internal const string Wizard_StepNextButtonImageUrl = "Wizard_StepNextButtonImageUrl";

	internal const string Wizard_StepPreviousButtonStyle = "Wizard_StepPreviousButtonStyle";

	internal const string Wizard_StepPreviousButtonText = "Wizard_StepPreviousButtonText";

	internal const string Wizard_StepPreviousButtonType = "Wizard_StepPreviousButtonType";

	internal const string Wizard_StepPreviousButtonImageUrl = "Wizard_StepPreviousButtonImageUrl";

	internal const string Wizard_SideBarButtonStyle = "Wizard_SideBarButtonStyle";

	internal const string Wizard_DisplaySideBar = "Wizard_DisplaySideBar";

	internal const string Wizard_SideBarStyle = "Wizard_SideBarStyle";

	internal const string Wizard_SideBarTemplate = "Wizard_SideBarTemplate";

	internal const string Wizard_StartNavigationTemplate = "Wizard_StartNavigationTemplate";

	internal const string Wizard_StartNextButtonStyle = "Wizard_StartNextButtonStyle";

	internal const string Wizard_StartNextButtonText = "Wizard_StartNextButtonText";

	internal const string Wizard_StartNextButtonType = "Wizard_StartNextButtonType";

	internal const string Wizard_StartNextButtonImageUrl = "Wizard_StartNextButtonImageUrl";

	internal const string Wizard_Step_Not_In_Wizard = "Wizard_Step_Not_In_Wizard";

	internal const string Wizard_StepNavigationTemplate = "Wizard_StepNavigationTemplate";

	internal const string Wizard_StepStyle = "Wizard_StepStyle";

	internal const string Wizard_WizardSteps = "Wizard_WizardSteps";

	internal const string Wizard_HeaderText = "Wizard_HeaderText";

	internal const string Wizard_Default_SkipToContentText = "Wizard_Default_SkipToContentText";

	internal const string Wizard_ActiveStepChanged = "Wizard_ActiveStepChanged";

	internal const string Wizard_FinishButtonClick = "Wizard_FinishButtonClick";

	internal const string Wizard_NextButtonClick = "Wizard_NextButtonClick";

	internal const string Wizard_PreviousButtonClick = "Wizard_PreviousButtonClick";

	internal const string Wizard_SideBarButtonClick = "Wizard_SideBarButtonClick";

	internal const string Wizard_Default_StepPreviousButtonText = "Wizard_Default_StepPreviousButtonText";

	internal const string Wizard_Default_StepNextButtonText = "Wizard_Default_StepNextButtonText";

	internal const string Wizard_Default_FinishButtonText = "Wizard_Default_FinishButtonText";

	internal const string Wizard_SideBar_Button_Not_Found = "Wizard_SideBar_Button_Not_Found";

	internal const string Wizard_DataList_Not_Found = "Wizard_DataList_Not_Found";

	internal const string Wizard_Cannot_Modify_ControlCollection = "Wizard_Cannot_Modify_ControlCollection";

	internal const string Wizard_Header_Placeholder_Must_Be_Specified_For_HeaderTemplate = "Wizard_Header_Placeholder_Must_Be_Specified_For_HeaderTemplate";

	internal const string Wizard_Header_Placeholder_Must_Be_Specified_For_HeaderText = "Wizard_Header_Placeholder_Must_Be_Specified_For_HeaderText";

	internal const string Wizard_Navigation_Placeholder_Must_Be_Specified = "Wizard_Navigation_Placeholder_Must_Be_Specified";

	internal const string Wizard_Sidebar_Placeholder_Must_Be_Specified = "Wizard_Sidebar_Placeholder_Must_Be_Specified";

	internal const string Wizard_Step_Placeholder_Must_Be_Specified = "Wizard_Step_Placeholder_Must_Be_Specified";

	internal const string Wizard_LayoutTemplate = "Wizard_LayoutTemplate";

	internal const string Wizard_WizardStepOnly = "Wizard_WizardStepOnly";

	internal const string WizardStep_AllowReturn = "WizardStep_AllowReturn";

	internal const string WizardStep_Name = "WizardStep_Name";

	internal const string WizardStep_Title = "WizardStep_Title";

	internal const string WizardStep_StepType = "WizardStep_StepType";

	internal const string WizardStep_WrongContainment = "WizardStep_WrongContainment";

	internal const string Xml_DocumentContent = "Xml_DocumentContent";

	internal const string Xml_DocumentSource = "Xml_DocumentSource";

	internal const string Xml_TransformSource = "Xml_TransformSource";

	internal const string Xml_Document = "Xml_Document";

	internal const string Xml_Transform = "Xml_Transform";

	internal const string Xml_TransformArgumentList = "Xml_TransformArgumentList";

	internal const string Xml_XPathNavigator = "Xml_XPathNavigator";

	internal const string XmlDataSource_Data = "XmlDataSource_Data";

	internal const string XmlDataSource_DataFile = "XmlDataSource_DataFile";

	internal const string XmlDataSource_Transform = "XmlDataSource_Transform";

	internal const string XmlDataSource_TransformFile = "XmlDataSource_TransformFile";

	internal const string XmlDataSource_XPath = "XmlDataSource_XPath";

	internal const string XmlDataSource_Transforming = "XmlDataSource_Transforming";

	internal const string AppearanceEditorPart_Title = "AppearanceEditorPart_Title";

	internal const string AppearanceEditorPart_Height = "AppearanceEditorPart_Height";

	internal const string AppearanceEditorPart_Width = "AppearanceEditorPart_Width";

	internal const string AppearanceEditorPart_ChromeType = "AppearanceEditorPart_ChromeType";

	internal const string AppearanceEditorPart_Hidden = "AppearanceEditorPart_Hidden";

	internal const string AppearanceEditorPart_Direction = "AppearanceEditorPart_Direction";

	internal const string AppearanceEditorPart_PartTitle = "AppearanceEditorPart_PartTitle";

	internal const string AppearanceEditorPart_Pixels = "AppearanceEditorPart_Pixels";

	internal const string AppearanceEditorPart_Points = "AppearanceEditorPart_Points";

	internal const string AppearanceEditorPart_Picas = "AppearanceEditorPart_Picas";

	internal const string AppearanceEditorPart_Inches = "AppearanceEditorPart_Inches";

	internal const string AppearanceEditorPart_Millimeters = "AppearanceEditorPart_Millimeters";

	internal const string AppearanceEditorPart_Centimeters = "AppearanceEditorPart_Centimeters";

	internal const string AppearanceEditorPart_Percent = "AppearanceEditorPart_Percent";

	internal const string AppearanceEditorPart_Em = "AppearanceEditorPart_Em";

	internal const string AppearanceEditorPart_Ex = "AppearanceEditorPart_Ex";

	internal const string BehaviorEditorPart_AllowClose = "BehaviorEditorPart_AllowClose";

	internal const string BehaviorEditorPart_AllowConnect = "BehaviorEditorPart_AllowConnect";

	internal const string BehaviorEditorPart_AllowHide = "BehaviorEditorPart_AllowHide";

	internal const string BehaviorEditorPart_AllowMinimize = "BehaviorEditorPart_AllowMinimize";

	internal const string BehaviorEditorPart_AllowZoneChange = "BehaviorEditorPart_AllowZoneChange";

	internal const string BehaviorEditorPart_ExportMode = "BehaviorEditorPart_ExportMode";

	internal const string BehaviorEditorPart_ExportModeNone = "BehaviorEditorPart_ExportModeNone";

	internal const string BehaviorEditorPart_ExportModeAll = "BehaviorEditorPart_ExportModeAll";

	internal const string BehaviorEditorPart_ExportModeNonSensitiveData = "BehaviorEditorPart_ExportModeNonSensitiveData";

	internal const string BehaviorEditorPart_HelpMode = "BehaviorEditorPart_HelpMode";

	internal const string BehaviorEditorPart_HelpModeModal = "BehaviorEditorPart_HelpModeModal";

	internal const string BehaviorEditorPart_HelpModeModeless = "BehaviorEditorPart_HelpModeModeless";

	internal const string BehaviorEditorPart_HelpModeNavigate = "BehaviorEditorPart_HelpModeNavigate";

	internal const string BehaviorEditorPart_Description = "BehaviorEditorPart_Description";

	internal const string BehaviorEditorPart_TitleLink = "BehaviorEditorPart_TitleLink";

	internal const string BehaviorEditorPart_TitleIconImageLink = "BehaviorEditorPart_TitleIconImageLink";

	internal const string BehaviorEditorPart_CatalogIconImageLink = "BehaviorEditorPart_CatalogIconImageLink";

	internal const string BehaviorEditorPart_HelpLink = "BehaviorEditorPart_HelpLink";

	internal const string BehaviorEditorPart_ImportErrorMessage = "BehaviorEditorPart_ImportErrorMessage";

	internal const string BehaviorEditorPart_AuthorizationFilter = "BehaviorEditorPart_AuthorizationFilter";

	internal const string BehaviorEditorPart_AllowEdit = "BehaviorEditorPart_AllowEdit";

	internal const string BehaviorEditorPart_PartTitle = "BehaviorEditorPart_PartTitle";

	internal const string BlobPersonalizationState_CantApply = "BlobPersonalizationState_CantApply";

	internal const string BlobPersonalizationState_CantExtract = "BlobPersonalizationState_CantExtract";

	internal const string BlobPersonalizationState_DeserializeError = "BlobPersonalizationState_DeserializeError";

	internal const string BlobPersonalizationState_NotApplied = "BlobPersonalizationState_NotApplied";

	internal const string BlobPersonalizationState_NotLoaded = "BlobPersonalizationState_NotLoaded";

	internal const string CatalogPart_MustBeInZone = "CatalogPart_MustBeInZone";

	internal const string CatalogPart_SampleWebPartTitle = "CatalogPart_SampleWebPartTitle";

	internal const string CatalogPart_UnknownDescription = "CatalogPart_UnknownDescription";

	internal const string CatalogZone_OnlyCatalogParts = "CatalogZone_OnlyCatalogParts";

	internal const string CatalogZoneBase_AddVerb = "CatalogZoneBase_AddVerb";

	internal const string CatalogZoneBase_CloseVerb = "CatalogZoneBase_CloseVerb";

	internal const string CatalogZoneBase_DefaultEmptyZoneText = "CatalogZoneBase_DefaultEmptyZoneText";

	internal const string CatalogZoneBase_DefaultSelectTargetZoneText = "CatalogZoneBase_DefaultSelectTargetZoneText";

	internal const string CatalogZoneBase_HeaderText = "CatalogZoneBase_HeaderText";

	internal const string CatalogZoneBase_InstructionText = "CatalogZoneBase_InstructionText";

	internal const string CatalogZoneBase_NoCatalogPartID = "CatalogZoneBase_NoCatalogPartID";

	internal const string CatalogZoneBase_PartLinkStyle = "CatalogZoneBase_PartLinkStyle";

	internal const string CatalogZoneBase_SelectCatalogPart = "CatalogZoneBase_SelectCatalogPart";

	internal const string CatalogZoneBase_SelectedCatalogPartID = "CatalogZoneBase_SelectedCatalogPartID";

	internal const string CatalogZoneBase_SelectedPartLinkStyle = "CatalogZoneBase_SelectedPartLinkStyle";

	internal const string CatalogZoneBase_SelectTargetZoneText = "CatalogZoneBase_SelectTargetZoneText";

	internal const string CatalogZoneBase_ShowCatalogIcons = "CatalogZoneBase_ShowCatalogIcons";

	internal const string ConnectionConsumerAttribute_InvalidConnectionPointType = "ConnectionConsumerAttribute_InvalidConnectionPointType";

	internal const string ConnectionProviderAttribute_InvalidConnectionPointType = "ConnectionProviderAttribute_InvalidConnectionPointType";

	internal const string ConnectionsZone_CancelVerb = "ConnectionsZone_CancelVerb";

	internal const string ConnectionsZone_ConfigureConnectionTitle = "ConnectionsZone_ConfigureConnectionTitle";

	internal const string ConnectionsZone_ConfigureConnectionTitleDescription = "ConnectionsZone_ConfigureConnectionTitleDescription";

	internal const string ConnectionsZone_ConfigureVerb = "ConnectionsZone_ConfigureVerb";

	internal const string ConnectionsZone_ConnectToConsumerInstructionText = "ConnectionsZone_ConnectToConsumerInstructionText";

	internal const string ConnectionsZone_ConnectToConsumerInstructionTextDescription = "ConnectionsZone_ConnectToConsumerInstructionTextDescription";

	internal const string ConnectionsZone_ConnectToConsumerText = "ConnectionsZone_ConnectToConsumerText";

	internal const string ConnectionsZone_ConnectToConsumerTextDescription = "ConnectionsZone_ConnectToConsumerTextDescription";

	internal const string ConnectionsZone_ConnectToConsumerTitle = "ConnectionsZone_ConnectToConsumerTitle";

	internal const string ConnectionsZone_ConnectToConsumerTitleDescription = "ConnectionsZone_ConnectToConsumerTitleDescription";

	internal const string ConnectionsZone_ConnectToProviderInstructionText = "ConnectionsZone_ConnectToProviderInstructionText";

	internal const string ConnectionsZone_ConnectToProviderInstructionTextDescription = "ConnectionsZone_ConnectToProviderInstructionTextDescription";

	internal const string ConnectionsZone_ConnectToProviderText = "ConnectionsZone_ConnectToProviderText";

	internal const string ConnectionsZone_ConnectToProviderTextDescription = "ConnectionsZone_ConnectToProviderTextDescription";

	internal const string ConnectionsZone_ConnectToProviderTitle = "ConnectionsZone_ConnectToProviderTitle";

	internal const string ConnectionsZone_ConnectToProviderTitleDescription = "ConnectionsZone_ConnectToProviderTitleDescription";

	internal const string ConnectionsZone_ConnectVerb = "ConnectionsZone_ConnectVerb";

	internal const string ConnectionsZone_ConsumersInstructionText = "ConnectionsZone_ConsumersInstructionText";

	internal const string ConnectionsZone_ConsumersInstructionTextDescription = "ConnectionsZone_ConsumersInstructionTextDescription";

	internal const string ConnectionsZone_ConsumersTitle = "ConnectionsZone_ConsumersTitle";

	internal const string ConnectionsZone_ConsumersTitleDescription = "ConnectionsZone_ConsumersTitleDescription";

	internal const string ConnectionsZone_CloseVerb = "ConnectionsZone_CloseVerb";

	internal const string ConnectionsZone_DisconnectVerb = "ConnectionsZone_DisconnectVerb";

	internal const string ConnectionsZone_DisconnectInvalid = "ConnectionsZone_DisconnectInvalid";

	internal const string ConnectionsZone_ErrorCantContinueConnectionCreation = "ConnectionsZone_ErrorCantContinueConnectionCreation";

	internal const string ConnectionsZone_ErrorMessage = "ConnectionsZone_ErrorMessage";

	internal const string ConnectionsZone_Get = "ConnectionsZone_Get";

	internal const string ConnectionsZone_GetDescription = "ConnectionsZone_GetDescription";

	internal const string ConnectionsZone_GetFromText = "ConnectionsZone_GetFromText";

	internal const string ConnectionsZone_GetFromTextDescription = "ConnectionsZone_GetFromTextDescription";

	internal const string ConnectionsZone_HeaderText = "ConnectionsZone_HeaderText";

	internal const string ConnectionsZone_HeaderTextDescription = "ConnectionsZone_HeaderTextDescription";

	internal const string ConnectionsZone_InstructionText = "ConnectionsZone_InstructionText";

	internal const string ConnectionsZone_InstructionTextDescription = "ConnectionsZone_InstructionTextDescription";

	internal const string ConnectionsZone_InstructionTitle = "ConnectionsZone_InstructionTitle";

	internal const string ConnectionsZone_InstructionTitleDescription = "ConnectionsZone_InstructionTitleDescription";

	internal const string ConnectionsZone_MustImplementITransformerConfigurationControl = "ConnectionsZone_MustImplementITransformerConfigurationControl";

	internal const string ConnectionsZone_NoConsumers = "ConnectionsZone_NoConsumers";

	internal const string ConnectionsZone_NoExistingConnectionTitle = "ConnectionsZone_NoExistingConnectionTitle";

	internal const string ConnectionsZone_NoExistingConnectionTitleDescription = "ConnectionsZone_NoExistingConnectionTitleDescription";

	internal const string ConnectionsZone_NoExistingConnectionInstructionText = "ConnectionsZone_NoExistingConnectionInstructionText";

	internal const string ConnectionsZone_NoExistingConnectionInstructionTextDescription = "ConnectionsZone_NoExistingConnectionInstructionTextDescription";

	internal const string ConnectionsZone_NoProviders = "ConnectionsZone_NoProviders";

	internal const string ConnectionsZone_ProvidersInstructionText = "ConnectionsZone_ProvidersInstructionText";

	internal const string ConnectionsZone_ProvidersInstructionTextDescription = "ConnectionsZone_ProvidersInstructionTextDescription";

	internal const string ConnectionsZone_ProvidersTitle = "ConnectionsZone_ProvidersTitle";

	internal const string ConnectionsZone_ProvidersTitleDescription = "ConnectionsZone_ProvidersTitleDescription";

	internal const string ConnectionsZone_SendText = "ConnectionsZone_SendText";

	internal const string ConnectionsZone_SendTextDescription = "ConnectionsZone_SendTextDescription";

	internal const string ConnectionsZone_SendToText = "ConnectionsZone_SendToText";

	internal const string ConnectionsZone_SendToTextDescription = "ConnectionsZone_SendToTextDescription";

	internal const string ConnectionsZone_WarningConnectionDisabled = "ConnectionsZone_WarningConnectionDisabled";

	internal const string ConnectionsZone_WarningMessage = "ConnectionsZone_WarningMessage";

	internal const string ConnectionPoint_InvalidControlType = "ConnectionPoint_InvalidControlType";

	internal const string ContentDirection_NotSet = "ContentDirection_NotSet";

	internal const string ContentDirection_LeftToRight = "ContentDirection_LeftToRight";

	internal const string ContentDirection_RightToLeft = "ContentDirection_RightToLeft";

	internal const string DeclarativeCatalogPart_PartTitle = "DeclarativeCatalogPart_PartTitle";

	internal const string DeclarativeCatlaogPart_WebPartsListUserControlPath = "DeclarativeCatlaogPart_WebPartsListUserControlPath";

	internal const string EditorPart_MustBeInZone = "EditorPart_MustBeInZone";

	internal const string EditorPart_ErrorBadUrl = "EditorPart_ErrorBadUrl";

	internal const string EditorPart_ErrorConvertingProperty = "EditorPart_ErrorConvertingProperty";

	internal const string EditorPart_ErrorConvertingPropertyWithType = "EditorPart_ErrorConvertingPropertyWithType";

	internal const string EditorPart_ErrorSettingProperty = "EditorPart_ErrorSettingProperty";

	internal const string EditorPart_ErrorSettingPropertyWithExceptionMessage = "EditorPart_ErrorSettingPropertyWithExceptionMessage";

	internal const string EditorPart_PropertyMaxValue = "EditorPart_PropertyMaxValue";

	internal const string EditorPart_PropertyMinValue = "EditorPart_PropertyMinValue";

	internal const string EditorPart_PropertyMustBeDecimal = "EditorPart_PropertyMustBeDecimal";

	internal const string EditorPart_PropertyMustBeInteger = "EditorPart_PropertyMustBeInteger";

	internal const string EditorZone_OnlyEditorParts = "EditorZone_OnlyEditorParts";

	internal const string EditorZoneBase_ApplyVerb = "EditorZoneBase_ApplyVerb";

	internal const string EditorZoneBase_CancelVerb = "EditorZoneBase_CancelVerb";

	internal const string EditorZoneBase_DefaultEmptyZoneText = "EditorZoneBase_DefaultEmptyZoneText";

	internal const string EditorZoneBase_DefaultErrorText = "EditorZoneBase_DefaultErrorText";

	internal const string EditorZoneBase_DefaultHeaderText = "EditorZoneBase_DefaultHeaderText";

	internal const string EditorZoneBase_DefaultInstructionText = "EditorZoneBase_DefaultInstructionText";

	internal const string EditorZoneBase_ErrorText = "EditorZoneBase_ErrorText";

	internal const string EditorZoneBase_NoEditorPartID = "EditorZoneBase_NoEditorPartID";

	internal const string EditorZoneBase_OKVerb = "EditorZoneBase_OKVerb";

	internal const string ErrorWebPart_ErrorText = "ErrorWebPart_ErrorText";

	internal const string GenericWebPart_CannotWrapWebPart = "GenericWebPart_CannotWrapWebPart";

	internal const string GenericWebPart_CannotWrapOutputCachedControl = "GenericWebPart_CannotWrapOutputCachedControl";

	internal const string GenericWebPart_NoID = "GenericWebPart_NoID";

	internal const string GenericWebPart_CannotModify = "GenericWebPart_CannotModify";

	internal const string GenericWebPart_ChildControlIsNull = "GenericWebPart_ChildControlIsNull";

	internal const string ImportCatalogPart_PartTitle = "ImportCatalogPart_PartTitle";

	internal const string ImportCatalogPart_Browse = "ImportCatalogPart_Browse";

	internal const string ImportCatalogPart_BrowseHelpText = "ImportCatalogPart_BrowseHelpText";

	internal const string ImportCatalogPart_Upload = "ImportCatalogPart_Upload";

	internal const string ImportCatalogPart_UploadHelpText = "ImportCatalogPart_UploadHelpText";

	internal const string ImportCatalogPart_UploadButton = "ImportCatalogPart_UploadButton";

	internal const string ImportCatalogPart_UploadButtonText = "ImportCatalogPart_UploadButtonText";

	internal const string ImportCatalogPart_ImportedPartLabel = "ImportCatalogPart_ImportedPartLabel";

	internal const string ImportCatalogPart_ImportedPartErrorLabel = "ImportCatalogPart_ImportedPartErrorLabel";

	internal const string ImportCatalogPart_PartImportErrorLabelText = "ImportCatalogPart_PartImportErrorLabelText";

	internal const string ImportCatalogPart_ImportedPartLabelText = "ImportCatalogPart_ImportedPartLabelText";

	internal const string ImportCatalogPart_NoFileName = "ImportCatalogPart_NoFileName";

	internal const string LayoutEditorPart_ChromeState = "LayoutEditorPart_ChromeState";

	internal const string LayoutEditorPart_Zone = "LayoutEditorPart_Zone";

	internal const string LayoutEditorPart_ZoneIndex = "LayoutEditorPart_ZoneIndex";

	internal const string LayoutEditorPart_PartTitle = "LayoutEditorPart_PartTitle";

	internal const string PageCatalogPart_PartTitle = "PageCatalogPart_PartTitle";

	internal const string Part_Description = "Part_Description";

	internal const string Part_ChromeState = "Part_ChromeState";

	internal const string Part_ChromeType = "Part_ChromeType";

	internal const string Part_Title = "Part_Title";

	internal const string Part_Unknown = "Part_Unknown";

	internal const string Part_Untitled = "Part_Untitled";

	internal const string PartChromeState_Normal = "PartChromeState_Normal";

	internal const string PartChromeState_Minimized = "PartChromeState_Minimized";

	internal const string PartChromeType_Default = "PartChromeType_Default";

	internal const string PartChromeType_TitleAndBorder = "PartChromeType_TitleAndBorder";

	internal const string PartChromeType_TitleOnly = "PartChromeType_TitleOnly";

	internal const string PartChromeType_BorderOnly = "PartChromeType_BorderOnly";

	internal const string PartChromeType_None = "PartChromeType_None";

	internal const string PersonalizableTypeEntry_InvalidProperty = "PersonalizableTypeEntry_InvalidProperty";

	internal const string PersonalizationDictionary_MustBeTypeString = "PersonalizationDictionary_MustBeTypeString";

	internal const string PersonalizationDictionary_MustBeTypePersonalizationEntry = "PersonalizationDictionary_MustBeTypePersonalizationEntry";

	internal const string PersonalizationDictionary_MustBeTypeDictionaryEntryArray = "PersonalizationDictionary_MustBeTypeDictionaryEntryArray";

	internal const string PersonalizationProvider_ApplicationNameExceedMaxLength = "PersonalizationProvider_ApplicationNameExceedMaxLength";

	internal const string PersonalizationProvider_BadConnection = "PersonalizationProvider_BadConnection";

	internal const string PersonalizationProvider_CantAccess = "PersonalizationProvider_CantAccess";

	internal const string PersonalizationProvider_NoConnection = "PersonalizationProvider_NoConnection";

	internal const string PersonalizationProvider_UnknownProp = "PersonalizationProvider_UnknownProp";

	internal const string PersonalizationProvider_WrongType = "PersonalizationProvider_WrongType";

	internal const string PropertyGridEditorPart_PartTitle = "PropertyGridEditorPart_PartTitle";

	internal const string PropertyGridEditorPart_DesignModeWebPart_BoolProperty = "PropertyGridEditorPart_DesignModeWebPart_BoolProperty";

	internal const string PropertyGridEditorPart_DesignModeWebPart_EnumProperty = "PropertyGridEditorPart_DesignModeWebPart_EnumProperty";

	internal const string PropertyGridEditorPart_DesignModeWebPart_StringProperty = "PropertyGridEditorPart_DesignModeWebPart_StringProperty";

	internal const string ProxyWebPartConnectionCollection_ReadOnly = "ProxyWebPartConnectionCollection_ReadOnly";

	internal const string RowToFieldTransformer_FieldName = "RowToFieldTransformer_FieldName";

	internal const string RowToFieldTransformer_NoProviderSchema = "RowToFieldTransformer_NoProviderSchema";

	internal const string RowToParametersTransformer_DifferentFieldNamesLength = "RowToParametersTransformer_DifferentFieldNamesLength";

	internal const string RowToParametersTransformer_ConsumerFieldName = "RowToParametersTransformer_ConsumerFieldName";

	internal const string RowToParametersTransformer_NoConsumerSchema = "RowToParametersTransformer_NoConsumerSchema";

	internal const string RowToParametersTransformer_ProviderFieldName = "RowToParametersTransformer_ProviderFieldName";

	internal const string RowToParametersTransformer_NoProviderSchema = "RowToParametersTransformer_NoProviderSchema";

	internal const string SqlPersonalizationProvider_Description = "SqlPersonalizationProvider_Description";

	internal const string ToolZone_CantSetVisible = "ToolZone_CantSetVisible";

	internal const string ToolZone_EditUIStyle = "ToolZone_EditUIStyle";

	internal const string ToolZone_HeaderCloseVerb = "ToolZone_HeaderCloseVerb";

	internal const string ToolZone_HeaderVerbStyle = "ToolZone_HeaderVerbStyle";

	internal const string ToolZone_InstructionText = "ToolZone_InstructionText";

	internal const string ToolZone_InstructionTextStyle = "ToolZone_InstructionTextStyle";

	internal const string ToolZone_LabelStyle = "ToolZone_LabelStyle";

	internal const string ToolZone_DisplayModesReadOnly = "ToolZone_DisplayModesReadOnly";

	internal const string WebPartTransformerAttribute_Missing = "WebPartTransformerAttribute_Missing";

	internal const string WebPartTransformerAttribute_NotTransformer = "WebPartTransformerAttribute_NotTransformer";

	internal const string WebPartTransformerAttribute_SameTypes = "WebPartTransformerAttribute_SameTypes";

	internal const string WebPartTransformerCollection_NotEmpty = "WebPartTransformerCollection_NotEmpty";

	internal const string WebPartTransformerCollection_ReadOnly = "WebPartTransformerCollection_ReadOnly";

	internal const string UnknownWebPart = "UnknownWebPart";

	internal const string WebPart_AllowClose = "WebPart_AllowClose";

	internal const string WebPart_AllowConnect = "WebPart_AllowConnect";

	internal const string WebPart_AllowEdit = "WebPart_AllowEdit";

	internal const string WebPart_AllowHide = "WebPart_AllowHide";

	internal const string WebPart_AllowMinimize = "WebPart_AllowMinimize";

	internal const string WebPart_AllowZoneChange = "WebPart_AllowZoneChange";

	internal const string WebPart_AuthorizationFilter = "WebPart_AuthorizationFilter";

	internal const string WebPart_BadUrl = "WebPart_BadUrl";

	internal const string WebPart_CatalogIconImageUrl = "WebPart_CatalogIconImageUrl";

	internal const string WebPart_CantSetExportMode = "WebPart_CantSetExportMode";

	internal const string WebPart_DefaultImportErrorMessage = "WebPart_DefaultImportErrorMessage";

	internal const string WebPart_ErrorFormatString = "WebPart_ErrorFormatString";

	internal const string WebPart_ExportMode = "WebPart_ExportMode";

	internal const string WebPart_HelpMode = "WebPart_HelpMode";

	internal const string WebPart_HelpUrl = "WebPart_HelpUrl";

	internal const string WebPart_Hidden = "WebPart_Hidden";

	internal const string WebPart_HiddenFormatString = "WebPart_HiddenFormatString";

	internal const string WebPart_ImportErrorInvalidVersion = "WebPart_ImportErrorInvalidVersion";

	internal const string WebPart_ImportErrorMessage = "WebPart_ImportErrorMessage";

	internal const string WebPart_ImportErrorNoVersion = "WebPart_ImportErrorNoVersion";

	internal const string WebPart_NonWebPart = "WebPart_NonWebPart";

	internal const string WebPart_NotStandalone = "WebPart_NotStandalone";

	internal const string WebPart_OnlyStandalone = "WebPart_OnlyStandalone";

	internal const string WebPart_SetZoneTemplateTooLate = "WebPart_SetZoneTemplateTooLate";

	internal const string WebPart_TitleIconImageUrl = "WebPart_TitleIconImageUrl";

	internal const string WebPart_TitleUrl = "WebPart_TitleUrl";

	internal const string WebPart_Collection_DuplicateID = "WebPart_Collection_DuplicateID";

	internal const string WebPartActionVerb_CantSetChecked = "WebPartActionVerb_CantSetChecked";

	internal const string WebPartCatalogAddVerb_Description = "WebPartCatalogAddVerb_Description";

	internal const string WebPartCatalogAddVerb_Text = "WebPartCatalogAddVerb_Text";

	internal const string WebPartCatalogCloseVerb_Description = "WebPartCatalogCloseVerb_Description";

	internal const string WebPartCatalogCloseVerb_Text = "WebPartCatalogCloseVerb_Text";

	internal const string WebPartChrome_ConfirmExportSensitive = "WebPartChrome_ConfirmExportSensitive";

	internal const string WebPartCloseVerb_Description = "WebPartCloseVerb_Description";

	internal const string WebPartCloseVerb_Text = "WebPartCloseVerb_Text";

	internal const string WebPartConnectVerb_Description = "WebPartConnectVerb_Description";

	internal const string WebPartConnectVerb_Text = "WebPartConnectVerb_Text";

	internal const string WebPartConnection_ConsumerIDNotSet = "WebPartConnection_ConsumerIDNotSet";

	internal const string WebPartConnection_ConsumerRequiresSecondaryInterfaces = "WebPartConnection_ConsumerRequiresSecondaryInterfaces";

	internal const string WebPartConnection_DisabledConnectionPoint = "WebPartConnection_DisabledConnectionPoint";

	internal const string WebPartConnection_Duplicate = "WebPartConnection_Duplicate";

	internal const string WebPartConnection_IncompatibleConsumerTransformer = "WebPartConnection_IncompatibleConsumerTransformer";

	internal const string WebPartConnection_IncompatibleConsumerTransformerWithType = "WebPartConnection_IncompatibleConsumerTransformerWithType";

	internal const string WebPartConnection_IncompatibleProviderTransformer = "WebPartConnection_IncompatibleProviderTransformer";

	internal const string WebPartConnection_IncompatibleProviderTransformerWithType = "WebPartConnection_IncompatibleProviderTransformerWithType";

	internal const string WebPartConnection_IncompatibleSecondaryInterfaces = "WebPartConnection_IncompatibleSecondaryInterfaces";

	internal const string WebPartConnection_NoCommonInterface = "WebPartConnection_NoCommonInterface";

	internal const string WebPartConnection_NoConsumer = "WebPartConnection_NoConsumer";

	internal const string WebPartConnection_NoConsumerConnectionPoint = "WebPartConnection_NoConsumerConnectionPoint";

	internal const string WebPartConnection_NoID = "WebPartConnection_NoID";

	internal const string WebPartConnection_NoProvider = "WebPartConnection_NoProvider";

	internal const string WebPartConnection_NoProviderConnectionPoint = "WebPartConnection_NoProviderConnectionPoint";

	internal const string WebPartConnection_ProviderIDNotSet = "WebPartConnection_ProviderIDNotSet";

	internal const string WebPartConnection_TransformerNotAvailable = "WebPartConnection_TransformerNotAvailable";

	internal const string WebPartConnection_TransformerNotAvailableWithType = "WebPartConnection_TransformerNotAvailableWithType";

	internal const string WebPartConnectionsCancelVerb_Description = "WebPartConnectionsCancelVerb_Description";

	internal const string WebPartConnectionsCancelVerb_Text = "WebPartConnectionsCancelVerb_Text";

	internal const string WebPartConnectionsCloseVerb_Description = "WebPartConnectionsCloseVerb_Description";

	internal const string WebPartConnectionsCloseVerb_Text = "WebPartConnectionsCloseVerb_Text";

	internal const string WebPartConnectionsConfigureVerb_Description = "WebPartConnectionsConfigureVerb_Description";

	internal const string WebPartConnectionsConfigureVerb_Text = "WebPartConnectionsConfigureVerb_Text";

	internal const string WebPartConnectionsConnectVerb_Description = "WebPartConnectionsConnectVerb_Description";

	internal const string WebPartConnectionsConnectVerb_Text = "WebPartConnectionsConnectVerb_Text";

	internal const string WebPartConnectionsDisconnectVerb_Description = "WebPartConnectionsDisconnectVerb_Description";

	internal const string WebPartConnectionsDisconnectVerb_Text = "WebPartConnectionsDisconnectVerb_Text";

	internal const string WebPartDeleteVerb_Description = "WebPartDeleteVerb_Description";

	internal const string WebPartDeleteVerb_Text = "WebPartDeleteVerb_Text";

	internal const string WebPartDisplayModeCollection_CantRemove = "WebPartDisplayModeCollection_CantRemove";

	internal const string WebPartDisplayModeCollection_CantSet = "WebPartDisplayModeCollection_CantSet";

	internal const string WebPartDisplayModeCollection_DuplicateName = "WebPartDisplayModeCollection_DuplicateName";

	internal const string WebPartEditorApplyVerb_Description = "WebPartEditorApplyVerb_Description";

	internal const string WebPartEditorApplyVerb_Text = "WebPartEditorApplyVerb_Text";

	internal const string WebPartEditorCancelVerb_Description = "WebPartEditorCancelVerb_Description";

	internal const string WebPartEditorCancelVerb_Text = "WebPartEditorCancelVerb_Text";

	internal const string WebPartEditorOKVerb_Description = "WebPartEditorOKVerb_Description";

	internal const string WebPartEditorOKVerb_Text = "WebPartEditorOKVerb_Text";

	internal const string WebPartEditVerb_Description = "WebPartEditVerb_Description";

	internal const string WebPartEditVerb_Text = "WebPartEditVerb_Text";

	internal const string WebPartExportHandler_InvalidArgument = "WebPartExportHandler_InvalidArgument";

	internal const string WebPartExportHandler_DisabledExportHandler = "WebPartExportHandler_DisabledExportHandler";

	internal const string WebPartExportVerb_Description = "WebPartExportVerb_Description";

	internal const string WebPartExportVerb_Text = "WebPartExportVerb_Text";

	internal const string WebPartHeaderCloseVerb_Description = "WebPartHeaderCloseVerb_Description";

	internal const string WebPartHeaderCloseVerb_Text = "WebPartHeaderCloseVerb_Text";

	internal const string WebPartHelpVerb_Description = "WebPartHelpVerb_Description";

	internal const string WebPartHelpVerb_Text = "WebPartHelpVerb_Text";

	internal const string WebPartManager_Personalization = "WebPartManager_Personalization";

	internal const string WebPartManager_MustRegister = "WebPartManager_MustRegister";

	internal const string WebPartManager_UnknownConnection = "WebPartManager_UnknownConnection";

	internal const string WebPartManager_AlreadyInConnect = "WebPartManager_AlreadyInConnect";

	internal const string WebPartManager_AlreadyInZone = "WebPartManager_AlreadyInZone";

	internal const string WebPartManager_MustBeInConnect = "WebPartManager_MustBeInConnect";

	internal const string WebPartManager_AlreadyInEdit = "WebPartManager_AlreadyInEdit";

	internal const string WebPartManager_MustBeInEdit = "WebPartManager_MustBeInEdit";

	internal const string WebPartManager_InvalidConnectionPoint = "WebPartManager_InvalidConnectionPoint";

	internal const string WebPartManager_NoSelectedWebPartConnect = "WebPartManager_NoSelectedWebPartConnect";

	internal const string WebPartManager_NoSelectedWebPartEdit = "WebPartManager_NoSelectedWebPartEdit";

	internal const string WebPartManager_MustBeInZone = "WebPartManager_MustBeInZone";

	internal const string WebPartManager_OnlyOneInstance = "WebPartManager_OnlyOneInstance";

	internal const string WebPartManager_AlreadyRegistered = "WebPartManager_AlreadyRegistered";

	internal const string WebPartManager_NoZoneID = "WebPartManager_NoZoneID";

	internal const string WebPartManager_DuplicateZoneID = "WebPartManager_DuplicateZoneID";

	internal const string WebPartManager_CannotModify = "WebPartManager_CannotModify";

	internal const string WebPartManager_NoWebPartID = "WebPartManager_NoWebPartID";

	internal const string WebPartManager_NoChildControlID = "WebPartManager_NoChildControlID";

	internal const string WebPartManager_DuplicateWebPartID = "WebPartManager_DuplicateWebPartID";

	internal const string WebPartManager_StaticConnections = "WebPartManager_StaticConnections";

	internal const string WebPartManager_InvalidConsumerSignature = "WebPartManager_InvalidConsumerSignature";

	internal const string WebPartManager_InvalidProviderSignature = "WebPartManager_InvalidProviderSignature";

	internal const string WebPartManager_ConnectTooLate = "WebPartManager_ConnectTooLate";

	internal const string WebPartManager_DisconnectTooLate = "WebPartManager_DisconnectTooLate";

	internal const string WebPartManager_EnableClientScript = "WebPartManager_EnableClientScript";

	internal const string WebPartManager_ForbiddenType = "WebPartManager_ForbiddenType";

	internal const string WebPartManager_PartNotExportable = "WebPartManager_PartNotExportable";

	internal const string WebPartManager_ImportInvalidFormat = "WebPartManager_ImportInvalidFormat";

	internal const string WebPartManager_ImportInvalidData = "WebPartManager_ImportInvalidData";

	internal const string WebPartManager_RegisterTooLate = "WebPartManager_RegisterTooLate";

	internal const string WebPartManager_ExportSensitiveDataWarning = "WebPartManager_ExportSensitiveDataWarning";

	internal const string WebPartManager_AlreadyDisconnected = "WebPartManager_AlreadyDisconnected";

	internal const string WebPartManager_ConnectionsReadOnly = "WebPartManager_ConnectionsReadOnly";

	internal const string WebPartManager_DynamicConnectionsReadOnly = "WebPartManager_DynamicConnectionsReadOnly";

	internal const string WebPartManager_StaticConnectionsReadOnly = "WebPartManager_StaticConnectionsReadOnly";

	internal const string WebPartManager_DisplayModesReadOnly = "WebPartManager_DisplayModesReadOnly";

	internal const string WebPartManager_InvalidDisplayMode = "WebPartManager_InvalidDisplayMode";

	internal const string WebPartManager_DisabledDisplayMode = "WebPartManager_DisabledDisplayMode";

	internal const string WebPartManager_CloseProviderWarning = "WebPartManager_CloseProviderWarning";

	internal const string WebPartManager_DefaultCloseProviderWarning = "WebPartManager_DefaultCloseProviderWarning";

	internal const string WebPartManager_DeleteWarning = "WebPartManager_DeleteWarning";

	internal const string WebPartManager_DefaultDeleteWarning = "WebPartManager_DefaultDeleteWarning";

	internal const string WebPartManager_CantConnectClosed = "WebPartManager_CantConnectClosed";

	internal const string WebPartManager_DuplicateConnectionID = "WebPartManager_DuplicateConnectionID";

	internal const string WebPartManager_AuthorizeWebPart = "WebPartManager_AuthorizeWebPart";

	internal const string WebPartManager_ConnectionsActivated = "WebPartManager_ConnectionsActivated";

	internal const string WebPartManager_ConnectionsActivating = "WebPartManager_ConnectionsActivating";

	internal const string WebPartManager_DisplayModeChanged = "WebPartManager_DisplayModeChanged";

	internal const string WebPartManager_DisplayModeChanging = "WebPartManager_DisplayModeChanging";

	internal const string WebPartManager_SelectedWebPartChanged = "WebPartManager_SelectedWebPartChanged";

	internal const string WebPartManager_SelectedWebPartChanging = "WebPartManager_SelectedWebPartChanging";

	internal const string WebPartManager_WebPartAdded = "WebPartManager_WebPartAdded";

	internal const string WebPartManager_WebPartAdding = "WebPartManager_WebPartAdding";

	internal const string WebPartManager_WebPartClosed = "WebPartManager_WebPartClosed";

	internal const string WebPartManager_WebPartClosing = "WebPartManager_WebPartClosing";

	internal const string WebPartManager_WebPartDeleted = "WebPartManager_WebPartDeleted";

	internal const string WebPartManager_WebPartDeleting = "WebPartManager_WebPartDeleting";

	internal const string WebPartManager_WebPartMoved = "WebPartManager_WebPartMoved";

	internal const string WebPartManager_WebPartMoving = "WebPartManager_WebPartMoving";

	internal const string WebPartManager_WebPartsConnected = "WebPartManager_WebPartsConnected";

	internal const string WebPartManager_WebPartsConnecting = "WebPartManager_WebPartsConnecting";

	internal const string WebPartManager_WebPartsDisconnected = "WebPartManager_WebPartsDisconnected";

	internal const string WebPartManager_WebPartsDisconnecting = "WebPartManager_WebPartsDisconnecting";

	internal const string WebPartManager_CantDeleteStatic = "WebPartManager_CantDeleteStatic";

	internal const string WebPartManager_CantDeleteSharedInUserScope = "WebPartManager_CantDeleteSharedInUserScope";

	internal const string WebPartManager_CantAddControlType = "WebPartManager_CantAddControlType";

	internal const string WebPartManager_PathCannotBeEmpty = "WebPartManager_PathCannotBeEmpty";

	internal const string WebPartManager_PathMustBeEmpty = "WebPartManager_PathMustBeEmpty";

	internal const string WebPartManager_CantCreateInstance = "WebPartManager_CantCreateInstance";

	internal const string WebPartManager_CantCreateInstanceWithType = "WebPartManager_CantCreateInstanceWithType";

	internal const string WebPartManager_TypeMustDeriveFromControl = "WebPartManager_TypeMustDeriveFromControl";

	internal const string WebPartManager_TypeMustDeriveFromControlWithType = "WebPartManager_TypeMustDeriveFromControlWithType";

	internal const string WebPartManager_InvalidPath = "WebPartManager_InvalidPath";

	internal const string WebPartManager_InvalidPathWithPath = "WebPartManager_InvalidPathWithPath";

	internal const string WebPartManager_CantCreateGeneric = "WebPartManager_CantCreateGeneric";

	internal const string WebPartManager_CantBeginConnectingClosed = "WebPartManager_CantBeginConnectingClosed";

	internal const string WebPartManager_CantBeginEditingClosed = "WebPartManager_CantBeginEditingClosed";

	internal const string WebPartManager_AlreadyClosed = "WebPartManager_AlreadyClosed";

	internal const string WebPartManager_CantSetEnableTheming = "WebPartManager_CantSetEnableTheming";

	internal const string WebPartManager_CantConnectToSelf = "WebPartManager_CantConnectToSelf";

	internal const string WebPartManager_ErrorLoadingWebPartType = "WebPartManager_ErrorLoadingWebPartType";

	internal const string WebPartManagerRequired = "WebPartManagerRequired";

	internal const string WebPartMenu_DefaultDropDownAlternateText = "WebPartMenu_DefaultDropDownAlternateText";

	internal const string WebPartMenuStyle_ShadowColor = "WebPartMenuStyle_ShadowColor";

	internal const string WebPartMinimizeVerb_Description = "WebPartMinimizeVerb_Description";

	internal const string WebPartMinimizeVerb_Text = "WebPartMinimizeVerb_Text";

	internal const string WebPartPersonalization_CannotLoadPersonalization = "WebPartPersonalization_CannotLoadPersonalization";

	internal const string WebPartPersonalization_CannotEnterSharedScope = "WebPartPersonalization_CannotEnterSharedScope";

	internal const string WebPartPersonalization_CantCallMethodBeforeInit = "WebPartPersonalization_CantCallMethodBeforeInit";

	internal const string WebPartPersonalization_CantUsePropertyBeforeInit = "WebPartPersonalization_CantUsePropertyBeforeInit";

	internal const string WebPartPersonalization_Enabled = "WebPartPersonalization_Enabled";

	internal const string WebPartPersonalization_InitialScope = "WebPartPersonalization_InitialScope";

	internal const string WebPartPersonalization_MustSetBeforeInit = "WebPartPersonalization_MustSetBeforeInit";

	internal const string WebPartPersonalization_PersonalizationNotEnabled = "WebPartPersonalization_PersonalizationNotEnabled";

	internal const string WebPartPersonalization_PersonalizationNotModifiable = "WebPartPersonalization_PersonalizationNotModifiable";

	internal const string WebPartPersonalization_PersonalizationStateNotLoaded = "WebPartPersonalization_PersonalizationStateNotLoaded";

	internal const string WebPartPersonalization_ProviderName = "WebPartPersonalization_ProviderName";

	internal const string WebPartPersonalization_ProviderNotFound = "WebPartPersonalization_ProviderNotFound";

	internal const string WebPartPersonalization_SameType = "WebPartPersonalization_SameType";

	internal const string WebPartRestoreVerb_Description = "WebPartRestoreVerb_Description";

	internal const string WebPartRestoreVerb_Text = "WebPartRestoreVerb_Text";

	internal const string WebPartTracker_CircularConnection = "WebPartTracker_CircularConnection";

	internal const string WebPartVerb_Checked = "WebPartVerb_Checked";

	internal const string WebPartVerb_Description = "WebPartVerb_Description";

	internal const string WebPartVerb_Enabled = "WebPartVerb_Enabled";

	internal const string WebPartVerb_ImageUrl = "WebPartVerb_ImageUrl";

	internal const string WebPartVerb_Text = "WebPartVerb_Text";

	internal const string WebPartVerb_Visible = "WebPartVerb_Visible";

	internal const string WebPartZoneBase_AllowLayoutChange = "WebPartZoneBase_AllowLayoutChange";

	internal const string WebPartZoneBase_CloseVerb = "WebPartZoneBase_CloseVerb";

	internal const string WebPartZoneBase_ConnectVerb = "WebPartZoneBase_ConnectVerb";

	internal const string WebPartZoneBase_CreateVerbs = "WebPartZoneBase_CreateVerbs";

	internal const string WebPartZoneBase_DefaultEmptyZoneText = "WebPartZoneBase_DefaultEmptyZoneText";

	internal const string WebPartZoneBase_DeleteVerb = "WebPartZoneBase_DeleteVerb";

	internal const string WebPartZoneBase_DisplayTitleFallback = "WebPartZoneBase_DisplayTitleFallback";

	internal const string WebPartZoneBase_DragHighlightColor = "WebPartZoneBase_DragHighlightColor";

	internal const string WebPartZoneBase_EditVerb = "WebPartZoneBase_EditVerb";

	internal const string WebPartZoneBase_ExportVerb = "WebPartZoneBase_ExportVerb";

	internal const string WebPartZoneBase_HelpVerb = "WebPartZoneBase_HelpVerb";

	internal const string WebPartZoneBase_LayoutOrientation = "WebPartZoneBase_LayoutOrientation";

	internal const string WebPartZoneBase_MenuPopupStyle = "WebPartZoneBase_MenuPopupStyle";

	internal const string WebPartZoneBase_MenuCheckImageStyle = "WebPartZoneBase_MenuCheckImageStyle";

	internal const string WebPartZoneBase_MenuCheckImageUrl = "WebPartZoneBase_MenuCheckImageUrl";

	internal const string WebPartZoneBase_MenuLabelHoverStyle = "WebPartZoneBase_MenuLabelHoverStyle";

	internal const string WebPartZoneBase_MenuLabelStyle = "WebPartZoneBase_MenuLabelStyle";

	internal const string WebPartZoneBase_MenuLabelText = "WebPartZoneBase_MenuLabelText";

	internal const string WebPartZoneBase_MenuPopupImageUrl = "WebPartZoneBase_MenuPopupImageUrl";

	internal const string WebPartZoneBase_MenuVerbHoverStyle = "WebPartZoneBase_MenuVerbHoverStyle";

	internal const string WebPartZoneBase_MenuVerbStyle = "WebPartZoneBase_MenuVerbStyle";

	internal const string WebPartZoneBase_MinimizeVerb = "WebPartZoneBase_MinimizeVerb";

	internal const string WebPartZoneBase_RestoreVerb = "WebPartZoneBase_RestoreVerb";

	internal const string WebPartZoneBase_SelectedPartChromeStyle = "WebPartZoneBase_SelectedPartChromeStyle";

	internal const string WebPartZoneBase_ShowTitleIcons = "WebPartZoneBase_ShowTitleIcons";

	internal const string WebPartZoneBase_TitleBarVerbButtonType = "WebPartZoneBase_TitleBarVerbButtonType";

	internal const string WebPartZoneBase_TitleBarVerbStyle = "WebPartZoneBase_TitleBarVerbStyle";

	internal const string WebPartZoneBase_WebPartVerbRenderMode = "WebPartZoneBase_WebPartVerbRenderMode";

	internal const string Zone_AddedTooLate = "Zone_AddedTooLate";

	internal const string Zone_EmptyZoneText = "Zone_EmptyZoneText";

	internal const string Zone_EmptyZoneTextStyle = "Zone_EmptyZoneTextStyle";

	internal const string Zone_ErrorStyle = "Zone_ErrorStyle";

	internal const string Zone_FooterStyle = "Zone_FooterStyle";

	internal const string Zone_HeaderStyle = "Zone_HeaderStyle";

	internal const string Zone_HeaderText = "Zone_HeaderText";

	internal const string Zone_InvalidParent = "Zone_InvalidParent";

	internal const string Zone_Padding = "Zone_Padding";

	internal const string Zone_PartStyle = "Zone_PartStyle";

	internal const string Zone_PartChromePadding = "Zone_PartChromePadding";

	internal const string Zone_PartChromeStyle = "Zone_PartChromeStyle";

	internal const string Zone_PartChromeType = "Zone_PartChromeType";

	internal const string Zone_PartTitleStyle = "Zone_PartTitleStyle";

	internal const string Zone_VerbButtonType = "Zone_VerbButtonType";

	internal const string Zone_VerbStyle = "Zone_VerbStyle";

	internal const string Zone_SampleHeaderText = "Zone_SampleHeaderText";

	internal const string PersonalizationAdmin_UnexpectedResetSharedStateReturnValue = "PersonalizationAdmin_UnexpectedResetSharedStateReturnValue";

	internal const string PersonalizationAdmin_UnexpectedResetUserStateReturnValue = "PersonalizationAdmin_UnexpectedResetUserStateReturnValue";

	internal const string PersonalizationAdmin_UnexpectedPersonalizationProviderReturnValue = "PersonalizationAdmin_UnexpectedPersonalizationProviderReturnValue";

	internal const string PersonalizationStateInfoCollection_CouldNotAddSharedStateInfo = "PersonalizationStateInfoCollection_CouldNotAddSharedStateInfo";

	internal const string PersonalizationStateInfoCollection_CouldNotAddUserStateInfo = "PersonalizationStateInfoCollection_CouldNotAddUserStateInfo";

	internal const string PersonalizationStateQuery_IncorrectValueType = "PersonalizationStateQuery_IncorrectValueType";

	internal const string PersonalizationProviderHelper_CannotHaveCommaInString = "PersonalizationProviderHelper_CannotHaveCommaInString";

	internal const string PersonalizationProviderHelper_Empty_Collection = "PersonalizationProviderHelper_Empty_Collection";

	internal const string PersonalizationProviderHelper_Invalid_Less_Than_Parameter = "PersonalizationProviderHelper_Invalid_Less_Than_Parameter";

	internal const string PersonalizationProviderHelper_More_Than_One_Path = "PersonalizationProviderHelper_More_Than_One_Path";

	internal const string PersonalizationProviderHelper_Negative_Integer = "PersonalizationProviderHelper_Negative_Integer";

	internal const string PersonalizationProviderHelper_No_Usernames_Set_In_Shared_Scope = "PersonalizationProviderHelper_No_Usernames_Set_In_Shared_Scope";

	internal const string PersonalizationProviderHelper_Null_Entries = "PersonalizationProviderHelper_Null_Entries";

	internal const string PersonalizationProviderHelper_Null_Or_Empty_String_Entries = "PersonalizationProviderHelper_Null_Or_Empty_String_Entries";

	internal const string PersonalizationProviderHelper_TrimmedEmptyString = "PersonalizationProviderHelper_TrimmedEmptyString";

	internal const string PersonalizationProviderHelper_Trimmed_Entry_Value_Exceed_Maximum_Length = "PersonalizationProviderHelper_Trimmed_Entry_Value_Exceed_Maximum_Length";

	internal const string StringUtil_Trimmed_String_Exceed_Maximum_Length = "StringUtil_Trimmed_String_Exceed_Maximum_Length";

	internal const string Category_Accessibility = "Category_Accessibility";

	internal const string Category_Cache = "Category_Cache";

	internal const string Category_Control = "Category_Control";

	internal const string Category_Databindings = "Category_Databindings";

	internal const string Category_DefaultProperties = "Category_DefaultProperties";

	internal const string Category_Links = "Category_Links";

	internal const string Category_Navigation = "Category_Navigation";

	internal const string Category_Paging = "Category_Paging";

	internal const string Category_Parameter = "Category_Parameter";

	internal const string Category_Styles = "Category_Styles";

	internal const string Category_Validation = "Category_Validation";

	internal const string Category_Verbs = "Category_Verbs";

	internal const string Category_WebPart = "Category_WebPart";

	internal const string Category_WebPartAppearance = "Category_WebPartAppearance";

	internal const string Category_WebPartBehavior = "Category_WebPartBehavior";

	internal const string Error_Formatter_ASPNET_Error = "Error_Formatter_ASPNET_Error";

	internal const string Error_Formatter_Description = "Error_Formatter_Description";

	internal const string Error_Formatter_Source_File = "Error_Formatter_Source_File";

	internal const string Error_Formatter_No_Source_File = "Error_Formatter_No_Source_File";

	internal const string Error_Formatter_Version = "Error_Formatter_Version";

	internal const string Error_Formatter_CLR_Build = "Error_Formatter_CLR_Build";

	internal const string Error_Formatter_ASPNET_Build = "Error_Formatter_ASPNET_Build";

	internal const string Error_Formatter_Line = "Error_Formatter_Line";

	internal const string Error_Formatter_FusionLog = "Error_Formatter_FusionLog";

	internal const string Error_Formatter_FusionLogDesc = "Error_Formatter_FusionLogDesc";

	internal const string Unhandled_Err_Error = "Unhandled_Err_Error";

	internal const string Unhandled_Err_Desc = "Unhandled_Err_Desc";

	internal const string Unhandled_Err_Exception_Details = "Unhandled_Err_Exception_Details";

	internal const string Unhandled_Err_Stack_Trace = "Unhandled_Err_Stack_Trace";

	internal const string Unauthorized_Err_Desc1 = "Unauthorized_Err_Desc1";

	internal const string Unauthorized_Err_Desc2 = "Unauthorized_Err_Desc2";

	internal const string Security_Err_Error = "Security_Err_Error";

	internal const string Security_Err_Desc = "Security_Err_Desc";

	internal const string NotFound_Resource_Not_Found = "NotFound_Resource_Not_Found";

	internal const string NotFound_Http_404 = "NotFound_Http_404";

	internal const string NotFound_Requested_Url = "NotFound_Requested_Url";

	internal const string Forbidden_Type_Not_Served = "Forbidden_Type_Not_Served";

	internal const string Forbidden_Extension_Incorrect = "Forbidden_Extension_Incorrect";

	internal const string Forbidden_Extension_Desc = "Forbidden_Extension_Desc";

	internal const string Generic_Err_Title = "Generic_Err_Title";

	internal const string Generic_Err_Local_Desc = "Generic_Err_Local_Desc";

	internal const string Generic_Err_Remote_Desc = "Generic_Err_Remote_Desc";

	internal const string Generic_Err_Details_Title = "Generic_Err_Details_Title";

	internal const string Generic_Err_Local_Details_Desc = "Generic_Err_Local_Details_Desc";

	internal const string Generic_Err_Remote_Details_Desc = "Generic_Err_Remote_Details_Desc";

	internal const string Generic_Err_Local_Details_Sample = "Generic_Err_Local_Details_Sample";

	internal const string Generic_Err_Remote_Details_Sample = "Generic_Err_Remote_Details_Sample";

	internal const string Generic_Err_Notes_Title = "Generic_Err_Notes_Title";

	internal const string Generic_Err_Notes_Desc = "Generic_Err_Notes_Desc";

	internal const string Generic_Err_Local_Notes_Sample = "Generic_Err_Local_Notes_Sample";

	internal const string Generic_Err_Remote_Notes_Sample = "Generic_Err_Remote_Notes_Sample";

	internal const string CustomErrorFailed_Err_Desc = "CustomErrorFailed_Err_Desc";

	internal const string WithFile_No_Relevant_Line = "WithFile_No_Relevant_Line";

	internal const string Src_not_available = "Src_not_available";

	internal const string Src_not_available_nodebug = "Src_not_available_nodebug";

	internal const string WithFile_Line_Num = "WithFile_Line_Num";

	internal const string TmplCompilerErrorTitle = "TmplCompilerErrorTitle";

	internal const string TmplCompilerErrorDesc = "TmplCompilerErrorDesc";

	internal const string TmplCompilerCompleteOutput = "TmplCompilerCompleteOutput";

	internal const string TmplCompilerGeneratedFile = "TmplCompilerGeneratedFile";

	internal const string TmplConfigurationAdditionalError = "TmplConfigurationAdditionalError";

	internal const string TmplCompilerErrorSecTitle = "TmplCompilerErrorSecTitle";

	internal const string TmplCompilerFatalError = "TmplCompilerFatalError";

	internal const string TmplCompilerWarningBanner = "TmplCompilerWarningBanner";

	internal const string TmplCompilerWarningSecTitle = "TmplCompilerWarningSecTitle";

	internal const string TmplCompilerSourceSecTitle = "TmplCompilerSourceSecTitle";

	internal const string TmplCompilerSourceFileTitle = "TmplCompilerSourceFileTitle";

	internal const string TmplCompilerSourceFileLine = "TmplCompilerSourceFileLine";

	internal const string TmplCompilerLineHeader = "TmplCompilerLineHeader";

	internal const string Parser_Error = "Parser_Error";

	internal const string Parser_Desc = "Parser_Desc";

	internal const string Parser_Error_Message = "Parser_Error_Message";

	internal const string Parser_Source_Error = "Parser_Source_Error";

	internal const string Config_Error = "Config_Error";

	internal const string Config_Desc = "Config_Desc";

	internal const string File_Circular_Reference = "File_Circular_Reference";

	internal const string CantGenPropertySet = "CantGenPropertySet";

	internal const string Trace_Request = "Trace_Request";

	internal const string Trace_Status_Code = "Trace_Status_Code";

	internal const string Trace_Trace_Information = "Trace_Trace_Information";

	internal const string Trace_Category = "Trace_Category";

	internal const string Trace_From_First = "Trace_From_First";

	internal const string Trace_Message = "Trace_Message";

	internal const string Trace_Warning = "Trace_Warning";

	internal const string Trace_From_Last = "Trace_From_Last";

	internal const string Trace_Control_Tree = "Trace_Control_Tree";

	internal const string Trace_Control_Id = "Trace_Control_Id";

	internal const string Trace_Parent_Id = "Trace_Parent_Id";

	internal const string Trace_Type = "Trace_Type";

	internal const string Trace_Viewstate_Size = "Trace_Viewstate_Size";

	internal const string Trace_Controlstate_Size = "Trace_Controlstate_Size";

	internal const string Trace_Render_Size = "Trace_Render_Size";

	internal const string Trace_Session_State = "Trace_Session_State";

	internal const string Trace_Application_State = "Trace_Application_State";

	internal const string Trace_Request_Cookies_Collection = "Trace_Request_Cookies_Collection";

	internal const string Trace_Response_Cookies_Collection = "Trace_Response_Cookies_Collection";

	internal const string Trace_Headers_Collection = "Trace_Headers_Collection";

	internal const string Trace_Response_Headers_Collection = "Trace_Response_Headers_Collection";

	internal const string Trace_Form_Collection = "Trace_Form_Collection";

	internal const string Trace_Querystring_Collection = "Trace_Querystring_Collection";

	internal const string Trace_Server_Variables = "Trace_Server_Variables";

	internal const string Trace_Time_of_Request = "Trace_Time_of_Request";

	internal const string Trace_Url = "Trace_Url";

	internal const string Trace_Request_Type = "Trace_Request_Type";

	internal const string Trace_Request_Encoding = "Trace_Request_Encoding";

	internal const string Trace_Name = "Trace_Name";

	internal const string Trace_Value = "Trace_Value";

	internal const string Trace_Response_Encoding = "Trace_Response_Encoding";

	internal const string Trace_Session_Id = "Trace_Session_Id";

	internal const string Trace_No = "Trace_No";

	internal const string Trace_Application_Key = "Trace_Application_Key";

	internal const string Trace_Session_Key = "Trace_Session_Key";

	internal const string Trace_Size = "Trace_Size";

	internal const string Trace_Request_Details = "Trace_Request_Details";

	internal const string Trace_Application_Trace = "Trace_Application_Trace";

	internal const string Trace_Clear_Current = "Trace_Clear_Current";

	internal const string Trace_Physical_Directory = "Trace_Physical_Directory";

	internal const string Trace_Requests_This = "Trace_Requests_This";

	internal const string Trace_Remaining = "Trace_Remaining";

	internal const string Trace_File = "Trace_File";

	internal const string Trace_Verb = "Trace_Verb";

	internal const string Trace_View_Details = "Trace_View_Details";

	internal const string Trace_Render_Size_children = "Trace_Render_Size_children";

	internal const string Trace_Viewstate_Size_Nochildren = "Trace_Viewstate_Size_Nochildren";

	internal const string Trace_Controlstate_Size_Nochildren = "Trace_Controlstate_Size_Nochildren";

	internal const string Trace_Page = "Trace_Page";

	internal const string Trace_Error_Title = "Trace_Error_Title";

	internal const string Trace_Error_LocalOnly_Description = "Trace_Error_LocalOnly_Description";

	internal const string Trace_Error_LocalOnly_Details_Desc = "Trace_Error_LocalOnly_Details_Desc";

	internal const string Trace_Error_LocalOnly_Details_Sample = "Trace_Error_LocalOnly_Details_Sample";

	internal const string Trace_Error_Enabled_Description = "Trace_Error_Enabled_Description";

	internal const string Trace_Error_Enabled_Details_Desc = "Trace_Error_Enabled_Details_Desc";

	internal const string Trace_Error_Enabled_Details_Sample = "Trace_Error_Enabled_Details_Sample";

	internal const string WebPageTraceListener_Event = "WebPageTraceListener_Event";

	internal const string Adapter_GoLabel = "Adapter_GoLabel";

	internal const string Adapter_OKLabel = "Adapter_OKLabel";

	internal const string MenuAdapter_Up = "MenuAdapter_Up";

	internal const string MenuAdapter_UpOneLevel = "MenuAdapter_UpOneLevel";

	internal const string MenuAdapter_Expand = "MenuAdapter_Expand";

	internal const string PageAdapter_MustHaveFormRunatServer = "PageAdapter_MustHaveFormRunatServer";

	internal const string PageAdapter_RenderDelegateMustBeInServerForm = "PageAdapter_RenderDelegateMustBeInServerForm";

	internal const string SQL_Services_Database_Empty_Or_Space_Only_Arg = "SQL_Services_Database_Empty_Or_Space_Only_Arg";

	internal const string SQL_Services_Cant_connect_sql_database = "SQL_Services_Cant_connect_sql_database";

	internal const string SQL_Services_Invalid_Feature = "SQL_Services_Invalid_Feature";

	internal const string SQL_Services_Error_Deleting_Session_Job = "SQL_Services_Error_Deleting_Session_Job";

	internal const string SQL_Services_Error_Executing_Command = "SQL_Services_Error_Executing_Command";

	internal const string SQL_Services_Error_Cant_Uninstall_Nonempty_Table = "SQL_Services_Error_Cant_Uninstall_Nonempty_Table";

	internal const string SQL_Services_Error_Cant_Uninstall_Nonexisting_Database = "SQL_Services_Error_Cant_Uninstall_Nonexisting_Database";

	internal const string SQL_Services_Error_Cant_use_custom_database = "SQL_Services_Error_Cant_use_custom_database";

	internal const string SQL_Services_Error_missing_custom_database = "SQL_Services_Error_missing_custom_database";

	internal const string SQL_Services_Database_contains_invalid_chars = "SQL_Services_Database_contains_invalid_chars";

	internal const string Provider_missing_attribute = "Provider_missing_attribute";

	internal const string Invalid_provider_attribute = "Invalid_provider_attribute";

	internal const string Invalid_mail_template_provider_attribute = "Invalid_mail_template_provider_attribute";

	internal const string Unexpected_provider_attribute = "Unexpected_provider_attribute";

	internal const string Invalid_provider_positive_attributes = "Invalid_provider_positive_attributes";

	internal const string Invalid_provider_non_zero_positive_attributes = "Invalid_provider_non_zero_positive_attributes";

	internal const string Event_name_not_found = "Event_name_not_found";

	internal const string Event_name_invalid_code_range = "Event_name_invalid_code_range";

	internal const string Health_mon_profile_not_found = "Health_mon_profile_not_found";

	internal const string Health_mon_provider_not_found = "Health_mon_provider_not_found";

	internal const string Wmi_provider_cant_initialize = "Wmi_provider_cant_initialize";

	internal const string Invalid_max_event_details_length = "Invalid_max_event_details_length";

	internal const string Health_mon_buffer_mode_not_found = "Health_mon_buffer_mode_not_found";

	internal const string Invalid_attribute1_must_less_than_or_equal_attribute2 = "Invalid_attribute1_must_less_than_or_equal_attribute2";

	internal const string Invalid_attribute1_must_less_than_attribute2 = "Invalid_attribute1_must_less_than_attribute2";

	internal const string MailWebEventProvider_discard_warning = "MailWebEventProvider_discard_warning";

	internal const string MailWebEventProvider_events_drop_warning = "MailWebEventProvider_events_drop_warning";

	internal const string MailWebEventProvider_summary_body = "MailWebEventProvider_summary_body";

	internal const string WebEvent_event_email_subject = "WebEvent_event_email_subject";

	internal const string WebEvent_event_group_email_subject = "WebEvent_event_group_email_subject";

	internal const string WebEvent_event_email_subject_template_error = "WebEvent_event_email_subject_template_error";

	internal const string MailWebEventProvider_Warnings = "MailWebEventProvider_Warnings";

	internal const string MailWebEventProvider_Summary = "MailWebEventProvider_Summary";

	internal const string MailWebEventProvider_Application_Info = "MailWebEventProvider_Application_Info";

	internal const string MailWebEventProvider_Events = "MailWebEventProvider_Events";

	internal const string MailWebEventProvider_template_file_not_found_error = "MailWebEventProvider_template_file_not_found_error";

	internal const string MailWebEventProvider_template_runtime_error = "MailWebEventProvider_template_runtime_error";

	internal const string MailWebEventProvider_template_compile_error = "MailWebEventProvider_template_compile_error";

	internal const string MailWebEventProvider_template_error_no_details = "MailWebEventProvider_template_error_no_details";

	internal const string MailWebEventProvider_no_recipient_error = "MailWebEventProvider_no_recipient_error";

	internal const string Sql_webevent_provider_events_dropped = "Sql_webevent_provider_events_dropped";

	internal const string MailWebEventProvider_cannot_send_mail = "MailWebEventProvider_cannot_send_mail";

	internal const string Invalid_eventCode_error = "Invalid_eventCode_error";

	internal const string Invalid_eventDetailCode_error = "Invalid_eventDetailCode_error";

	internal const string System_eventCode_not_allowed = "System_eventCode_not_allowed";

	internal const string Event_log_provider_error = "Event_log_provider_error";

	internal const string Wmi_provider_error = "Wmi_provider_error";

	internal const string Webevent_msg_ApplicationStart = "Webevent_msg_ApplicationStart";

	internal const string Webevent_msg_ApplicationShutdown = "Webevent_msg_ApplicationShutdown";

	internal const string Webevent_msg_ApplicationCompilationStart = "Webevent_msg_ApplicationCompilationStart";

	internal const string Webevent_msg_ApplicationCompilationEnd = "Webevent_msg_ApplicationCompilationEnd";

	internal const string Webevent_msg_ApplicationHeartbeat = "Webevent_msg_ApplicationHeartbeat";

	internal const string Webevent_msg_RequestTransactionComplete = "Webevent_msg_RequestTransactionComplete";

	internal const string Webevent_msg_RequestTransactionAbort = "Webevent_msg_RequestTransactionAbort";

	internal const string Webevent_msg_RuntimeErrorRequestAbort = "Webevent_msg_RuntimeErrorRequestAbort";

	internal const string Webevent_msg_RuntimeErrorViewStateFailure = "Webevent_msg_RuntimeErrorViewStateFailure";

	internal const string Webevent_msg_RuntimeErrorValidationFailure = "Webevent_msg_RuntimeErrorValidationFailure";

	internal const string Webevent_msg_RuntimeErrorPostTooLarge = "Webevent_msg_RuntimeErrorPostTooLarge";

	internal const string Webevent_msg_RuntimeErrorUnhandledException = "Webevent_msg_RuntimeErrorUnhandledException";

	internal const string Webevent_msg_RuntimeErrorWebResourceFailure_DecryptionError = "Webevent_msg_RuntimeErrorWebResourceFailure_DecryptionError";

	internal const string Webevent_msg_RuntimeErrorWebResourceFailure_ResourceMissing = "Webevent_msg_RuntimeErrorWebResourceFailure_ResourceMissing";

	internal const string Webevent_msg_WebErrorParserError = "Webevent_msg_WebErrorParserError";

	internal const string Webevent_msg_WebErrorCompilationError = "Webevent_msg_WebErrorCompilationError";

	internal const string Webevent_msg_WebErrorConfigurationError = "Webevent_msg_WebErrorConfigurationError";

	internal const string Webevent_msg_AuditUnhandledSecurityException = "Webevent_msg_AuditUnhandledSecurityException";

	internal const string Webevent_msg_AuditInvalidViewStateFailure = "Webevent_msg_AuditInvalidViewStateFailure";

	internal const string Webevent_msg_AuditFormsAuthenticationSuccess = "Webevent_msg_AuditFormsAuthenticationSuccess";

	internal const string Webevent_msg_AuditUrlAuthorizationSuccess = "Webevent_msg_AuditUrlAuthorizationSuccess";

	internal const string Webevent_msg_AuditFileAuthorizationFailure = "Webevent_msg_AuditFileAuthorizationFailure";

	internal const string Webevent_msg_AuditFormsAuthenticationFailure = "Webevent_msg_AuditFormsAuthenticationFailure";

	internal const string Webevent_msg_AuditFileAuthorizationSuccess = "Webevent_msg_AuditFileAuthorizationSuccess";

	internal const string Webevent_msg_AuditMembershipAuthenticationSuccess = "Webevent_msg_AuditMembershipAuthenticationSuccess";

	internal const string Webevent_msg_AuditMembershipAuthenticationFailure = "Webevent_msg_AuditMembershipAuthenticationFailure";

	internal const string Webevent_msg_AuditUrlAuthorizationFailure = "Webevent_msg_AuditUrlAuthorizationFailure";

	internal const string Webevent_msg_AuditUnhandledAccessException = "Webevent_msg_AuditUnhandledAccessException";

	internal const string Webevent_msg_OSF_Deserialization_String = "Webevent_msg_OSF_Deserialization_String";

	internal const string Webevent_msg_OSF_Deserialization_Binary = "Webevent_msg_OSF_Deserialization_Binary";

	internal const string Webevent_msg_OSF_Deserialization_Type = "Webevent_msg_OSF_Deserialization_Type";

	internal const string Webevent_msg_Property_Deserialization = "Webevent_msg_Property_Deserialization";

	internal const string Webevent_detail_ApplicationShutdownUnknown = "Webevent_detail_ApplicationShutdownUnknown";

	internal const string Webevent_detail_ApplicationShutdownHostingEnvironment = "Webevent_detail_ApplicationShutdownHostingEnvironment";

	internal const string Webevent_detail_ApplicationShutdownChangeInGlobalAsax = "Webevent_detail_ApplicationShutdownChangeInGlobalAsax";

	internal const string Webevent_detail_ApplicationShutdownConfigurationChange = "Webevent_detail_ApplicationShutdownConfigurationChange";

	internal const string Webevent_detail_ApplicationShutdownUnloadAppDomainCalled = "Webevent_detail_ApplicationShutdownUnloadAppDomainCalled";

	internal const string Webevent_detail_ApplicationShutdownChangeInSecurityPolicyFile = "Webevent_detail_ApplicationShutdownChangeInSecurityPolicyFile";

	internal const string Webevent_detail_ApplicationShutdownBinDirChangeOrDirectoryRename = "Webevent_detail_ApplicationShutdownBinDirChangeOrDirectoryRename";

	internal const string Webevent_detail_ApplicationShutdownBrowsersDirChangeOrDirectoryRename = "Webevent_detail_ApplicationShutdownBrowsersDirChangeOrDirectoryRename";

	internal const string Webevent_detail_ApplicationShutdownCodeDirChangeOrDirectoryRename = "Webevent_detail_ApplicationShutdownCodeDirChangeOrDirectoryRename";

	internal const string Webevent_detail_ApplicationShutdownResourcesDirChangeOrDirectoryRename = "Webevent_detail_ApplicationShutdownResourcesDirChangeOrDirectoryRename";

	internal const string Webevent_detail_ApplicationShutdownIdleTimeout = "Webevent_detail_ApplicationShutdownIdleTimeout";

	internal const string Webevent_detail_ApplicationShutdownPhysicalApplicationPathChanged = "Webevent_detail_ApplicationShutdownPhysicalApplicationPathChanged";

	internal const string Webevent_detail_ApplicationShutdownHttpRuntimeClose = "Webevent_detail_ApplicationShutdownHttpRuntimeClose";

	internal const string Webevent_detail_ApplicationShutdownInitializationError = "Webevent_detail_ApplicationShutdownInitializationError";

	internal const string Webevent_detail_ApplicationShutdownMaxRecompilationsReached = "Webevent_detail_ApplicationShutdownMaxRecompilationsReached";

	internal const string Webevent_detail_ApplicationShutdownBuildManagerChange = "Webevent_detail_ApplicationShutdownBuildManagerChange";

	internal const string Webevent_detail_StateServerConnectionError = "Webevent_detail_StateServerConnectionError";

	internal const string Webevent_detail_InvalidTicketFailure = "Webevent_detail_InvalidTicketFailure";

	internal const string Webevent_detail_ExpiredTicketFailure = "Webevent_detail_ExpiredTicketFailure";

	internal const string Webevent_detail_InvalidViewStateMac = "Webevent_detail_InvalidViewStateMac";

	internal const string Webevent_detail_InvalidViewState = "Webevent_detail_InvalidViewState";

	internal const string Webevent_detail_SqlProviderEventsDropped = "Webevent_detail_SqlProviderEventsDropped";

	internal const string Webevent_event_code = "Webevent_event_code";

	internal const string Webevent_event_message = "Webevent_event_message";

	internal const string Webevent_event_time = "Webevent_event_time";

	internal const string Webevent_event_time_Utc = "Webevent_event_time_Utc";

	internal const string Webevent_event_sequence = "Webevent_event_sequence";

	internal const string Webevent_event_occurrence = "Webevent_event_occurrence";

	internal const string Webevent_event_id = "Webevent_event_id";

	internal const string Webevent_event_detail_code = "Webevent_event_detail_code";

	internal const string Webevent_event_process_information = "Webevent_event_process_information";

	internal const string Webevent_event_application_information = "Webevent_event_application_information";

	internal const string Webevent_event_process_statistics = "Webevent_event_process_statistics";

	internal const string Webevent_event_request_information = "Webevent_event_request_information";

	internal const string Webevent_event_exception_information = "Webevent_event_exception_information";

	internal const string Webevent_event_inner_exception_information = "Webevent_event_inner_exception_information";

	internal const string Webevent_event_exception_type = "Webevent_event_exception_type";

	internal const string Webevent_event_exception_message = "Webevent_event_exception_message";

	internal const string Webevent_event_thread_information = "Webevent_event_thread_information";

	internal const string Webevent_event_process_id = "Webevent_event_process_id";

	internal const string Webevent_event_process_name = "Webevent_event_process_name";

	internal const string Webevent_event_account_name = "Webevent_event_account_name";

	internal const string Webevent_event_machine_name = "Webevent_event_machine_name";

	internal const string Webevent_event_application_domain = "Webevent_event_application_domain";

	internal const string Webevent_event_trust_level = "Webevent_event_trust_level";

	internal const string Webevent_event_application_virtual_path = "Webevent_event_application_virtual_path";

	internal const string Webevent_event_application_path = "Webevent_event_application_path";

	internal const string Webevent_event_request_url = "Webevent_event_request_url";

	internal const string Webevent_event_request_path = "Webevent_event_request_path";

	internal const string Webevent_event_user = "Webevent_event_user";

	internal const string Webevent_event_is_authenticated = "Webevent_event_is_authenticated";

	internal const string Webevent_event_is_not_authenticated = "Webevent_event_is_not_authenticated";

	internal const string Webevent_event_authentication_type = "Webevent_event_authentication_type";

	internal const string Webevent_event_process_start_time = "Webevent_event_process_start_time";

	internal const string Webevent_event_thread_count = "Webevent_event_thread_count";

	internal const string Webevent_event_working_set = "Webevent_event_working_set";

	internal const string Webevent_event_peak_working_set = "Webevent_event_peak_working_set";

	internal const string Webevent_event_managed_heap_size = "Webevent_event_managed_heap_size";

	internal const string Webevent_event_application_domain_count = "Webevent_event_application_domain_count";

	internal const string Webevent_event_requests_executing = "Webevent_event_requests_executing";

	internal const string Webevent_event_request_queued = "Webevent_event_request_queued";

	internal const string Webevent_event_request_rejected = "Webevent_event_request_rejected";

	internal const string Webevent_event_thread_id = "Webevent_event_thread_id";

	internal const string Webevent_event_thread_account_name = "Webevent_event_thread_account_name";

	internal const string Webevent_event_is_impersonating = "Webevent_event_is_impersonating";

	internal const string Webevent_event_is_not_impersonating = "Webevent_event_is_not_impersonating";

	internal const string Webevent_event_stack_trace = "Webevent_event_stack_trace";

	internal const string Webevent_event_user_host_address = "Webevent_event_user_host_address";

	internal const string Webevent_event_name_to_authenticate = "Webevent_event_name_to_authenticate";

	internal const string Webevent_event_custom_event_details = "Webevent_event_custom_event_details";

	internal const string Webevent_event_ViewStateException_information = "Webevent_event_ViewStateException_information";

	internal const string Etw_Batch_Compilation = "Etw_Batch_Compilation";

	internal const string Etw_Success = "Etw_Success";

	internal const string Etw_Failure = "Etw_Failure";

	internal const string Config_collection_add_element_without_key = "Config_collection_add_element_without_key";

	internal const string Failed_Pipeline_Subscription = "Failed_Pipeline_Subscription";

	internal const string Cant_Init_Native_Config = "Cant_Init_Native_Config";

	internal const string Cant_Enumerate_NativeDirs = "Cant_Enumerate_NativeDirs";

	internal const string Cant_Read_Native_Modules = "Cant_Read_Native_Modules";

	internal const string Cant_Create_Process_Host = "Cant_Create_Process_Host";

	internal const string Invalid_AppDomain_Prot_Type = "Invalid_AppDomain_Prot_Type";

	internal const string Invalid_Process_Prot_Type = "Invalid_Process_Prot_Type";

	internal const string Invalid_Application_Preload_Provider_Type = "Invalid_Application_Preload_Provider_Type";

	internal const string Invalid_Enabled_Preload_Parameter = "Invalid_Enabled_Preload_Parameter";

	internal const string Failure_ApplicationPreloadUtil_Already_Set = "Failure_ApplicationPreloadUtil_Already_Set";

	internal const string Failure_Create_Application_Preload_Provider_Type = "Failure_Create_Application_Preload_Provider_Type";

	internal const string Failure_Preload_Application_Initialization = "Failure_Preload_Application_Initialization";

	internal const string Failure_Calling_Preload_Provider = "Failure_Calling_Preload_Provider";

	internal const string Failure_Stop_Listener_Channel = "Failure_Stop_Listener_Channel";

	internal const string Failure_Stop_Process_Prot = "Failure_Stop_Process_Prot";

	internal const string Failure_Start_AppDomain_Listener = "Failure_Start_AppDomain_Listener";

	internal const string Failure_Stop_AppDomain_Listener = "Failure_Stop_AppDomain_Listener";

	internal const string Failure_Stop_AppDomain_Protocol = "Failure_Stop_AppDomain_Protocol";

	internal const string Failure_Start_Integrated_App = "Failure_Start_Integrated_App";

	internal const string Failure_Stop_Integrated_App = "Failure_Stop_Integrated_App";

	internal const string Failure_Shutdown_ProcessHost = "Failure_Shutdown_ProcessHost";

	internal const string Failure_AppDomain_Enum = "Failure_AppDomain_Enum";

	internal const string Failure_PMH_Ping = "Failure_PMH_Ping";

	internal const string Failure_PMH_Idle = "Failure_PMH_Idle";

	internal const string Failure_Create_Listener_Shim = "Failure_Create_Listener_Shim";

	internal const string Event_Binding_Disallowed = "Event_Binding_Disallowed";

	internal const string Requires_Iis_Integrated_Mode = "Requires_Iis_Integrated_Mode";

	internal const string Method_Not_Supported_By_Iis_Integrated_Mode = "Method_Not_Supported_By_Iis_Integrated_Mode";

	internal const string Requires_Iis_7 = "Requires_Iis_7";

	internal const string Requires_Iis_75_Integrated = "Requires_Iis_75_Integrated";

	internal const string Invalid_before_authentication = "Invalid_before_authentication";

	internal const string Application_instance_cannot_be_changed = "Application_instance_cannot_be_changed";

	internal const string Invalid_http_data_chunk = "Invalid_http_data_chunk";

	internal const string Substitution_blocks_cannot_be_modified = "Substitution_blocks_cannot_be_modified";

	internal const string TransferRequest_cannot_be_invoked_more_than_once = "TransferRequest_cannot_be_invoked_more_than_once";

	internal const string Invoke_before_pipeline_event = "Invoke_before_pipeline_event";

	internal const string Invalid_queue_limit = "Invalid_queue_limit";

	internal const string Queue_limit_is_zero = "Queue_limit_is_zero";

	internal const string HttpMethodConstraint_ParameterValueMustBeString = "HttpMethodConstraint_ParameterValueMustBeString";

	internal const string Route_CannotHaveCatchAllInMultiSegment = "Route_CannotHaveCatchAllInMultiSegment";

	internal const string Route_CannotHaveConsecutiveParameters = "Route_CannotHaveConsecutiveParameters";

	internal const string Route_CannotHaveConsecutiveSeparators = "Route_CannotHaveConsecutiveSeparators";

	internal const string Route_CatchAllMustBeLast = "Route_CatchAllMustBeLast";

	internal const string Route_InvalidParameterName = "Route_InvalidParameterName";

	internal const string Route_InvalidRouteUrl = "Route_InvalidRouteUrl";

	internal const string Route_MismatchedParameter = "Route_MismatchedParameter";

	internal const string Route_RepeatedParameter = "Route_RepeatedParameter";

	internal const string Route_ValidationMustBeStringOrCustomConstraint = "Route_ValidationMustBeStringOrCustomConstraint";

	internal const string RouteCollection_DuplicateEntry = "RouteCollection_DuplicateEntry";

	internal const string RouteCollection_DuplicateName = "RouteCollection_DuplicateName";

	internal const string RouteCollection_NameNotFound = "RouteCollection_NameNotFound";

	internal const string RouteCollection_RequiresContext = "RouteCollection_RequiresContext";

	internal const string RouteData_RequiredValue = "RouteData_RequiredValue";

	internal const string RouteTable_ContextMissingRequest = "RouteTable_ContextMissingRequest";

	internal const string UrlRoutingHandler_NoRouteMatches = "UrlRoutingHandler_NoRouteMatches";

	internal const string UrlRoutingModule_NoHttpHandler = "UrlRoutingModule_NoHttpHandler";

	internal const string UrlRoutingModule_NoRouteHandler = "UrlRoutingModule_NoRouteHandler";

	internal const string RouteUrlExpression_InvalidExpression = "RouteUrlExpression_InvalidExpression";

	internal const string PageRouteHandler_InvalidVirtualPath = "PageRouteHandler_InvalidVirtualPath";

	internal const string RouteParameter_RouteKey = "RouteParameter_RouteKey";

	internal const string Control_NotADescendentOfNamingContainer = "Control_NotADescendentOfNamingContainer";

	internal const string DynamicModuleRegistry_ModulesAlreadyInitialized = "DynamicModuleRegistry_ModulesAlreadyInitialized";

	internal const string DynamicModuleRegistry_TypeIsNotIHttpModule = "DynamicModuleRegistry_TypeIsNotIHttpModule";

	internal const string StateApplication_FullTrustOnly = "StateApplication_FullTrustOnly";

	internal const string HttpTaskAsyncHandler_CannotExecuteSynchronously = "HttpTaskAsyncHandler_CannotExecuteSynchronously";

	internal const string SynchronizationContextUtil_AspCompatModeNotCompatible = "SynchronizationContextUtil_AspCompatModeNotCompatible";

	internal const string SynchronizationContextUtil_PageAsyncVoidMethodsNotCompatible = "SynchronizationContextUtil_PageAsyncVoidMethodsNotCompatible";

	internal const string SynchronizationContextUtil_TaskReturningPageAsyncMethodsNotCompatible = "SynchronizationContextUtil_TaskReturningPageAsyncMethodsNotCompatible";

	internal const string SynchronizationContextUtil_PageAsyncTaskTimeoutHandlerParallelNotCompatible = "SynchronizationContextUtil_PageAsyncTaskTimeoutHandlerParallelNotCompatible";

	internal const string SynchronizationContextUtil_WebSocketsNotCompatible = "SynchronizationContextUtil_WebSocketsNotCompatible";

	internal const string SynchronizationContextUtil_UpgradeToTargetFramework45Instructions = "SynchronizationContextUtil_UpgradeToTargetFramework45Instructions";

	internal const string SynchronizationContextUtil_AddDowngradeAppSettingsSwitch = "SynchronizationContextUtil_AddDowngradeAppSettingsSwitch";

	internal const string SynchronizationContextUtil_RemoveAppSettingsSwitch = "SynchronizationContextUtil_RemoveAppSettingsSwitch";

	internal const string SynchronizationContextUtil_ForMoreInformation = "SynchronizationContextUtil_ForMoreInformation";

	internal const string PageAsyncManager_CannotEnqueue = "PageAsyncManager_CannotEnqueue";

	internal const string TaskAsyncHelper_ParameterInvalid = "TaskAsyncHelper_ParameterInvalid";

	internal const string WebSockets_WebSocketModuleNotEnabled = "WebSockets_WebSocketModuleNotEnabled";

	internal const string WebSockets_NotAWebSocketRequest = "WebSockets_NotAWebSocketRequest";

	internal const string WebSockets_OriginCheckFailed = "WebSockets_OriginCheckFailed";

	internal const string WebSockets_SubProtocolCannotBeNegotiated = "WebSockets_SubProtocolCannotBeNegotiated";

	internal const string WebSockets_AcceptWebSocketRequestCanOnlyBeCalledOnce = "WebSockets_AcceptWebSocketRequestCanOnlyBeCalledOnce";

	internal const string WebSockets_CannotBeCalledDuringBeginRequest = "WebSockets_CannotBeCalledDuringBeginRequest";

	internal const string WebSockets_CannotBeCalledAfterHandlerExecute = "WebSockets_CannotBeCalledAfterHandlerExecute";

	internal const string WebSockets_CannotBeCalledDuringChildExecute = "WebSockets_CannotBeCalledDuringChildExecute";

	internal const string WebSockets_UnknownErrorWhileAccepting = "WebSockets_UnknownErrorWhileAccepting";

	internal const string WebSockets_MethodNotAvailableDuringWebSocketProcessing = "WebSockets_MethodNotAvailableDuringWebSocketProcessing";

	internal const string AspNetWebSocket_SendInProgress = "AspNetWebSocket_SendInProgress";

	internal const string AspNetWebSocket_SendMessageTypeInvalid = "AspNetWebSocket_SendMessageTypeInvalid";

	internal const string AspNetWebSocket_CloseAlreadySent = "AspNetWebSocket_CloseAlreadySent";

	internal const string AspNetWebSocket_ReceiveInProgress = "AspNetWebSocket_ReceiveInProgress";

	internal const string AspNetWebSocket_CloseAlreadyReceived = "AspNetWebSocket_CloseAlreadyReceived";

	internal const string AspNetWebSocket_CloseStatusEmptyButCloseDescriptionNonNull = "AspNetWebSocket_CloseStatusEmptyButCloseDescriptionNonNull";

	internal const string AspNetWebSocket_CloseDescriptionTooLong = "AspNetWebSocket_CloseDescriptionTooLong";

	internal const string AspNetWebSocket_DisposeNotSupported = "AspNetWebSocket_DisposeNotSupported";

	internal const string Common_NullOrEmpty = "Common_NullOrEmpty";

	internal const string Common_PropertyCannotBeNullOrEmpty = "Common_PropertyCannotBeNullOrEmpty";

	internal const string ValueProviderResult_ConversionThrew = "ValueProviderResult_ConversionThrew";

	internal const string ValueProviderResult_NoConverterExists = "ValueProviderResult_NoConverterExists";

	internal const string Common_PropertyNotFound = "Common_PropertyNotFound";

	internal const string DataAnnotationsModelMetadataProvider_UnknownProperty = "DataAnnotationsModelMetadataProvider_UnknownProperty";

	internal const string DataAnnotationsModelMetadataProvider_UnreadableProperty = "DataAnnotationsModelMetadataProvider_UnreadableProperty";

	internal const string Common_TypeMustDriveFromType = "Common_TypeMustDriveFromType";

	internal const string DataAnnotationsModelValidatorProvider_ConstructorRequirements = "DataAnnotationsModelValidatorProvider_ConstructorRequirements";

	internal const string ClientDataTypeModelValidatorProvider_FieldMustBeNumeric = "ClientDataTypeModelValidatorProvider_FieldMustBeNumeric";

	internal const string DataAnnotationsModelValidatorProvider_ValidatableConstructorRequirements = "DataAnnotationsModelValidatorProvider_ValidatableConstructorRequirements";

	internal const string ValidatableObjectAdapter_IncompatibleType = "ValidatableObjectAdapter_IncompatibleType";

	internal const string BindingBehavior_ValueNotFound = "BindingBehavior_ValueNotFound";

	internal const string Common_TypeMustImplementInterface = "Common_TypeMustImplementInterface";

	internal const string GenericModelBinderProvider_ParameterMustSpecifyOpenGenericType = "GenericModelBinderProvider_ParameterMustSpecifyOpenGenericType";

	internal const string GenericModelBinderProvider_TypeArgumentCountMismatch = "GenericModelBinderProvider_TypeArgumentCountMismatch";

	internal const string ModelBinderConfig_ValueInvalid = "ModelBinderConfig_ValueInvalid";

	internal const string ModelBinderConfig_ValueRequired = "ModelBinderConfig_ValueRequired";

	internal const string ModelBinderProviderCollection_BinderForTypeNotFound = "ModelBinderProviderCollection_BinderForTypeNotFound";

	internal const string ModelBinderProviderCollection_InvalidBinderType = "ModelBinderProviderCollection_InvalidBinderType";

	internal const string ModelBinderUtil_ModelCannotBeNull = "ModelBinderUtil_ModelCannotBeNull";

	internal const string ModelBinderUtil_ModelInstanceIsWrong = "ModelBinderUtil_ModelInstanceIsWrong";

	internal const string ModelBinderUtil_ModelMetadataCannotBeNull = "ModelBinderUtil_ModelMetadataCannotBeNull";

	internal const string ModelBinderUtil_ModelTypeIsWrong = "ModelBinderUtil_ModelTypeIsWrong";

	internal const string ModelBindingContext_ModelMetadataMustBeSet = "ModelBindingContext_ModelMetadataMustBeSet";

	internal const string AppVerifier_Title = "AppVerifier_Title";

	internal const string AppVerifier_Subtitle = "AppVerifier_Subtitle";

	internal const string AppVerifier_BasicInfo_URL = "AppVerifier_BasicInfo_URL";

	internal const string AppVerifier_BasicInfo_ErrorCode = "AppVerifier_BasicInfo_ErrorCode";

	internal const string AppVerifier_BasicInfo_Description = "AppVerifier_BasicInfo_Description";

	internal const string AppVerifier_BasicInfo_NotificationInfo = "AppVerifier_BasicInfo_NotificationInfo";

	internal const string AppVerifier_BasicInfo_ThreadInfo = "AppVerifier_BasicInfo_ThreadInfo";

	internal const string AppVerifier_BeginMethodInfo_EntryMethod = "AppVerifier_BeginMethodInfo_EntryMethod";

	internal const string AppVerifier_BeginMethodInfo_RequestNotification_Integrated = "AppVerifier_BeginMethodInfo_RequestNotification_Integrated";

	internal const string AppVerifier_BeginMethodInfo_RequestNotification_NotIntegrated = "AppVerifier_BeginMethodInfo_RequestNotification_NotIntegrated";

	internal const string AppVerifier_BeginMethodInfo_CurrentHandler = "AppVerifier_BeginMethodInfo_CurrentHandler";

	internal const string AppVerifier_BeginMethodInfo_ThreadInfo = "AppVerifier_BeginMethodInfo_ThreadInfo";

	internal const string AppVerifier_AsyncCallbackInfo_InvocationCount = "AppVerifier_AsyncCallbackInfo_InvocationCount";

	internal const string AppVerifier_AsyncCallbackInfo_FirstInvocation_ThreadInfo = "AppVerifier_AsyncCallbackInfo_FirstInvocation_ThreadInfo";

	internal const string AppVerifier_Errors_HttpApplicationInstanceWasNull = "AppVerifier_Errors_HttpApplicationInstanceWasNull";

	internal const string AppVerifier_Errors_BeginHandlerDelegateWasNull = "AppVerifier_Errors_BeginHandlerDelegateWasNull";

	internal const string AppVerifier_Errors_AsyncCallbackInvokedMultipleTimes = "AppVerifier_Errors_AsyncCallbackInvokedMultipleTimes";

	internal const string AppVerifier_Errors_AsyncCallbackInvokedWithNullParameter = "AppVerifier_Errors_AsyncCallbackInvokedWithNullParameter";

	internal const string AppVerifier_Errors_AsyncCallbackGivenAsyncResultWhichWasNotCompleted = "AppVerifier_Errors_AsyncCallbackGivenAsyncResultWhichWasNotCompleted";

	internal const string AppVerifier_Errors_AsyncCallbackInvokedAsynchronouslyButAsyncResultWasMarkedCompletedSynchronously = "AppVerifier_Errors_AsyncCallbackInvokedAsynchronouslyButAsyncResultWasMarkedCompletedSynchronously";

	internal const string AppVerifier_Errors_AsyncCallbackInvokedSynchronouslyButAsyncResultWasNotMarkedCompletedSynchronously = "AppVerifier_Errors_AsyncCallbackInvokedSynchronouslyButAsyncResultWasNotMarkedCompletedSynchronously";

	internal const string AppVerifier_Errors_AsyncCallbackInvokedWithUnexpectedAsyncResultInstance = "AppVerifier_Errors_AsyncCallbackInvokedWithUnexpectedAsyncResultInstance";

	internal const string AppVerifier_Errors_AsyncCallbackInvokedEvenThoughBeginHandlerThrew = "AppVerifier_Errors_AsyncCallbackInvokedEvenThoughBeginHandlerThrew";

	internal const string AppVerifier_Errors_AsyncCallbackInvokedWithUnexpectedAsyncResultAsyncState = "AppVerifier_Errors_AsyncCallbackInvokedWithUnexpectedAsyncResultAsyncState";

	internal const string AppVerifier_Errors_AsyncCallbackCalledAfterHttpApplicationReassigned = "AppVerifier_Errors_AsyncCallbackCalledAfterHttpApplicationReassigned";

	internal const string AppVerifier_Errors_BeginHandlerReturnedNull = "AppVerifier_Errors_BeginHandlerReturnedNull";

	internal const string AppVerifier_Errors_BeginHandlerReturnedAsyncResultMarkedCompletedSynchronouslyButWhichWasNotCompleted = "AppVerifier_Errors_BeginHandlerReturnedAsyncResultMarkedCompletedSynchronouslyButWhichWasNotCompleted";

	internal const string AppVerifier_Errors_BeginHandlerReturnedAsyncResultMarkedCompletedSynchronouslyButAsyncCallbackNeverCalled = "AppVerifier_Errors_BeginHandlerReturnedAsyncResultMarkedCompletedSynchronouslyButAsyncCallbackNeverCalled";

	internal const string AppVerifier_Errors_BeginHandlerReturnedUnexpectedAsyncResultAsyncState = "AppVerifier_Errors_BeginHandlerReturnedUnexpectedAsyncResultAsyncState";

	internal const string AppVerifier_Errors_SyncContextSendOrPostCalledAfterRequestCompleted = "AppVerifier_Errors_SyncContextSendOrPostCalledAfterRequestCompleted";

	internal const string AppVerifier_Errors_SyncContextSendOrPostCalledBetweenNotifications = "AppVerifier_Errors_SyncContextSendOrPostCalledBetweenNotifications";

	internal const string AppVerifier_Errors_SyncContextPostCalledInNestedNotification = "AppVerifier_Errors_SyncContextPostCalledInNestedNotification";

	internal const string AppVerifier_Errors_RequestNotificationCompletedSynchronouslyWithNotificationContextPending = "AppVerifier_Errors_RequestNotificationCompletedSynchronouslyWithNotificationContextPending";

	internal const string AppVerifier_Errors_NotificationContextHasChangedAfterSynchronouslyProcessingNotification = "AppVerifier_Errors_NotificationContextHasChangedAfterSynchronouslyProcessingNotification";

	internal const string AppVerifier_Errors_PendingProcessRequestNotificationStatusAfterCompletingNestedNotification = "AppVerifier_Errors_PendingProcessRequestNotificationStatusAfterCompletingNestedNotification";

	internal const string Request_Queue_Limit_Per_Session_Exceeded = "Request_Queue_Limit_Per_Session_Exceeded";

	internal const string MembershipPasswordFormat_Obsoleted = "MembershipPasswordFormat_Obsoleted";

	internal const string Unhandled_Monitor_Exception = "Unhandled_Monitor_Exception";

	internal const string OnExecuteRequestStep_Cannot_Be_Called = "OnExecuteRequestStep_Cannot_Be_Called";

	internal const string AdditionalConfigErrorInfo = "AdditionalConfigErrorInfo";

	private static SR loader;

	private ResourceManager resources;

	private static CultureInfo Culture => null;

	public static ResourceManager Resources => GetLoader().resources;

	internal SR()
	{
		resources = new ResourceManager("System.Web", GetType().Assembly);
	}

	private static SR GetLoader()
	{
		if (loader == null)
		{
			SR value = new SR();
			Interlocked.CompareExchange(ref loader, value, null);
		}

		return loader;
	}

	public static string GetString(string name, params object[] args)
	{
		SR sR = GetLoader();
		if (sR == null)
		{
			return null;
		}

		string @string = sR.resources.GetString(name, Culture);
		if (args != null && args.Length != 0)
		{
			for (int i = 0; i < args.Length; i++)
			{
				if (args[i] is string text && text.Length > 1024)
				{
					args[i] = text.Substring(0, 1021) + "...";
				}
			}

			return string.Format(CultureInfo.CurrentCulture, @string, args);
		}

		return @string;
	}

	public static string GetString(string name)
	{
		return GetLoader()?.resources.GetString(name, Culture);
	}

	public static string GetString(string name, out bool usedFallback)
	{
		usedFallback = false;
		return GetString(name);
	}

	public static object GetObject(string name)
	{
		return GetLoader()?.resources.GetObject(name, Culture);
	}
}
