/****** Object:  ForeignKey [FK_course_subtypes_course_types]    Script Date: 03/25/2012 00:57:36 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_course_subtypes_course_types]') AND parent_object_id = OBJECT_ID(N'[course_subtypes]'))
ALTER TABLE [course_subtypes] DROP CONSTRAINT [FK_course_subtypes_course_types]
GO
/****** Object:  ForeignKey [FK_course_time_classrooms]    Script Date: 03/25/2012 00:57:36 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_course_time_classrooms]') AND parent_object_id = OBJECT_ID(N'[course_time]'))
ALTER TABLE [course_time] DROP CONSTRAINT [FK_course_time_classrooms]
GO
/****** Object:  ForeignKey [FK_course_time_courses]    Script Date: 03/25/2012 00:57:36 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_course_time_courses]') AND parent_object_id = OBJECT_ID(N'[course_time]'))
ALTER TABLE [course_time] DROP CONSTRAINT [FK_course_time_courses]
GO
/****** Object:  ForeignKey [FK_course_time_day_of_week]    Script Date: 03/25/2012 00:57:36 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_course_time_day_of_week]') AND parent_object_id = OBJECT_ID(N'[course_time]'))
ALTER TABLE [course_time] DROP CONSTRAINT [FK_course_time_day_of_week]
GO
/****** Object:  ForeignKey [FK_courses_charge_type]    Script Date: 03/25/2012 00:57:36 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_courses_charge_type]') AND parent_object_id = OBJECT_ID(N'[courses]'))
ALTER TABLE [courses] DROP CONSTRAINT [FK_courses_charge_type]
GO
/****** Object:  ForeignKey [FK_courses_course_subtypes]    Script Date: 03/25/2012 00:57:36 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_courses_course_subtypes]') AND parent_object_id = OBJECT_ID(N'[courses]'))
ALTER TABLE [courses] DROP CONSTRAINT [FK_courses_course_subtypes]
GO
/****** Object:  ForeignKey [FK_deposit_list_students]    Script Date: 03/25/2012 00:57:36 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_deposit_list_students]') AND parent_object_id = OBJECT_ID(N'[deposit_list]'))
ALTER TABLE [deposit_list] DROP CONSTRAINT [FK_deposit_list_students]
GO
/****** Object:  ForeignKey [FK_student_cost_courses]    Script Date: 03/25/2012 00:57:37 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_student_cost_courses]') AND parent_object_id = OBJECT_ID(N'[student_cost]'))
ALTER TABLE [student_cost] DROP CONSTRAINT [FK_student_cost_courses]
GO
/****** Object:  ForeignKey [FK_student_cost_discount_level]    Script Date: 03/25/2012 00:57:37 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_student_cost_discount_level]') AND parent_object_id = OBJECT_ID(N'[student_cost]'))
ALTER TABLE [student_cost] DROP CONSTRAINT [FK_student_cost_discount_level]
GO
/****** Object:  ForeignKey [FK_student_cost_students]    Script Date: 03/25/2012 00:57:37 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_student_cost_students]') AND parent_object_id = OBJECT_ID(N'[student_cost]'))
ALTER TABLE [student_cost] DROP CONSTRAINT [FK_student_cost_students]
GO
/****** Object:  ForeignKey [FK_student_courses_courses]    Script Date: 03/25/2012 00:57:37 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_student_courses_courses]') AND parent_object_id = OBJECT_ID(N'[student_courses]'))
ALTER TABLE [student_courses] DROP CONSTRAINT [FK_student_courses_courses]
GO
/****** Object:  ForeignKey [FK_student_courses_students]    Script Date: 03/25/2012 00:57:37 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_student_courses_students]') AND parent_object_id = OBJECT_ID(N'[student_courses]'))
ALTER TABLE [student_courses] DROP CONSTRAINT [FK_student_courses_students]
GO
/****** Object:  ForeignKey [FK_student_courses_cost_courses]    Script Date: 03/25/2012 00:57:37 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_student_courses_cost_courses]') AND parent_object_id = OBJECT_ID(N'[student_courses_cost]'))
ALTER TABLE [student_courses_cost] DROP CONSTRAINT [FK_student_courses_cost_courses]
GO
/****** Object:  ForeignKey [FK_student_courses_cost_discount_level]    Script Date: 03/25/2012 00:57:37 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_student_courses_cost_discount_level]') AND parent_object_id = OBJECT_ID(N'[student_courses_cost]'))
ALTER TABLE [student_courses_cost] DROP CONSTRAINT [FK_student_courses_cost_discount_level]
GO
/****** Object:  ForeignKey [FK_student_courses_cost_students]    Script Date: 03/25/2012 00:57:37 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_student_courses_cost_students]') AND parent_object_id = OBJECT_ID(N'[student_courses_cost]'))
ALTER TABLE [student_courses_cost] DROP CONSTRAINT [FK_student_courses_cost_students]
GO
/****** Object:  ForeignKey [FK_student_signin_students]    Script Date: 03/25/2012 00:57:38 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_student_signin_students]') AND parent_object_id = OBJECT_ID(N'[student_signin]'))
ALTER TABLE [student_signin] DROP CONSTRAINT [FK_student_signin_students]
GO
/****** Object:  ForeignKey [FK_students_card_type]    Script Date: 03/25/2012 00:57:38 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_students_card_type]') AND parent_object_id = OBJECT_ID(N'[students]'))
ALTER TABLE [students] DROP CONSTRAINT [FK_students_card_type]
GO
/****** Object:  ForeignKey [FK_students_course_subtypes]    Script Date: 03/25/2012 00:57:38 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_students_course_subtypes]') AND parent_object_id = OBJECT_ID(N'[students]'))
ALTER TABLE [students] DROP CONSTRAINT [FK_students_course_subtypes]
GO
/****** Object:  ForeignKey [FK_students_student_status]    Script Date: 03/25/2012 00:57:38 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_students_student_status]') AND parent_object_id = OBJECT_ID(N'[students]'))
ALTER TABLE [students] DROP CONSTRAINT [FK_students_student_status]
GO
/****** Object:  View [dbo].[v_course]    Script Date: 03/25/2012 00:57:39 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_course]'))
DROP VIEW [v_course]
GO
/****** Object:  View [dbo].[v_student_courses]    Script Date: 03/25/2012 00:57:39 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_student_courses]'))
DROP VIEW [v_student_courses]
GO
/****** Object:  Table [dbo].[student_courses]    Script Date: 03/25/2012 00:57:37 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_student_courses_courses]') AND parent_object_id = OBJECT_ID(N'[student_courses]'))
ALTER TABLE [student_courses] DROP CONSTRAINT [FK_student_courses_courses]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_student_courses_students]') AND parent_object_id = OBJECT_ID(N'[student_courses]'))
ALTER TABLE [student_courses] DROP CONSTRAINT [FK_student_courses_students]
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_student_courses_Balance]') AND type = 'D')
BEGIN
ALTER TABLE [student_courses] DROP CONSTRAINT [DF_student_courses_Balance]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_student_courses_CourseNum]') AND type = 'D')
BEGIN
ALTER TABLE [student_courses] DROP CONSTRAINT [DF_student_courses_CourseNum]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[student_courses]') AND type in (N'U'))
DROP TABLE [student_courses]
GO
/****** Object:  Table [dbo].[student_courses_cost]    Script Date: 03/25/2012 00:57:37 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_student_courses_cost_courses]') AND parent_object_id = OBJECT_ID(N'[student_courses_cost]'))
ALTER TABLE [student_courses_cost] DROP CONSTRAINT [FK_student_courses_cost_courses]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_student_courses_cost_discount_level]') AND parent_object_id = OBJECT_ID(N'[student_courses_cost]'))
ALTER TABLE [student_courses_cost] DROP CONSTRAINT [FK_student_courses_cost_discount_level]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_student_courses_cost_students]') AND parent_object_id = OBJECT_ID(N'[student_courses_cost]'))
ALTER TABLE [student_courses_cost] DROP CONSTRAINT [FK_student_courses_cost_students]
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_student_courses_cost_Discount]') AND type = 'D')
BEGIN
ALTER TABLE [student_courses_cost] DROP CONSTRAINT [DF_student_courses_cost_Discount]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[student_courses_cost]') AND type in (N'U'))
DROP TABLE [student_courses_cost]
GO
/****** Object:  Table [dbo].[student_signin]    Script Date: 03/25/2012 00:57:38 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_student_signin_students]') AND parent_object_id = OBJECT_ID(N'[student_signin]'))
ALTER TABLE [student_signin] DROP CONSTRAINT [FK_student_signin_students]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[student_signin]') AND type in (N'U'))
DROP TABLE [student_signin]
GO
/****** Object:  View [dbo].[v_users_course]    Script Date: 03/25/2012 00:57:39 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_users_course]'))
DROP VIEW [v_users_course]
GO
/****** Object:  Table [dbo].[student_cost]    Script Date: 03/25/2012 00:57:37 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_student_cost_courses]') AND parent_object_id = OBJECT_ID(N'[student_cost]'))
ALTER TABLE [student_cost] DROP CONSTRAINT [FK_student_cost_courses]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_student_cost_discount_level]') AND parent_object_id = OBJECT_ID(N'[student_cost]'))
ALTER TABLE [student_cost] DROP CONSTRAINT [FK_student_cost_discount_level]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_student_cost_students]') AND parent_object_id = OBJECT_ID(N'[student_cost]'))
ALTER TABLE [student_cost] DROP CONSTRAINT [FK_student_cost_students]
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_student_cost_Discount]') AND type = 'D')
BEGIN
ALTER TABLE [student_cost] DROP CONSTRAINT [DF_student_cost_Discount]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[student_cost]') AND type in (N'U'))
DROP TABLE [student_cost]
GO
/****** Object:  Table [dbo].[deposit_list]    Script Date: 03/25/2012 00:57:36 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_deposit_list_students]') AND parent_object_id = OBJECT_ID(N'[deposit_list]'))
ALTER TABLE [deposit_list] DROP CONSTRAINT [FK_deposit_list_students]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[deposit_list]') AND type in (N'U'))
DROP TABLE [deposit_list]
GO
/****** Object:  Table [dbo].[course_time]    Script Date: 03/25/2012 00:57:36 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_course_time_classrooms]') AND parent_object_id = OBJECT_ID(N'[course_time]'))
ALTER TABLE [course_time] DROP CONSTRAINT [FK_course_time_classrooms]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_course_time_courses]') AND parent_object_id = OBJECT_ID(N'[course_time]'))
ALTER TABLE [course_time] DROP CONSTRAINT [FK_course_time_courses]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_course_time_day_of_week]') AND parent_object_id = OBJECT_ID(N'[course_time]'))
ALTER TABLE [course_time] DROP CONSTRAINT [FK_course_time_day_of_week]
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_course_time_BeginTime]') AND type = 'D')
BEGIN
ALTER TABLE [course_time] DROP CONSTRAINT [DF_course_time_BeginTime]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_course_time_EndTime]') AND type = 'D')
BEGIN
ALTER TABLE [course_time] DROP CONSTRAINT [DF_course_time_EndTime]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[course_time]') AND type in (N'U'))
DROP TABLE [course_time]
GO
/****** Object:  Table [dbo].[courses]    Script Date: 03/25/2012 00:57:36 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_courses_charge_type]') AND parent_object_id = OBJECT_ID(N'[courses]'))
ALTER TABLE [courses] DROP CONSTRAINT [FK_courses_charge_type]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_courses_course_subtypes]') AND parent_object_id = OBJECT_ID(N'[courses]'))
ALTER TABLE [courses] DROP CONSTRAINT [FK_courses_course_subtypes]
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_courses_CourseChargeType]') AND type = 'D')
BEGIN
ALTER TABLE [courses] DROP CONSTRAINT [DF_courses_CourseChargeType]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_courses_ChargeAmount]') AND type = 'D')
BEGIN
ALTER TABLE [courses] DROP CONSTRAINT [DF_courses_ChargeAmount]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[courses]') AND type in (N'U'))
DROP TABLE [courses]
GO
/****** Object:  View [dbo].[v_cards]    Script Date: 03/25/2012 00:57:39 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_cards]'))
DROP VIEW [v_cards]
GO
/****** Object:  Table [dbo].[students]    Script Date: 03/25/2012 00:57:38 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_students_card_type]') AND parent_object_id = OBJECT_ID(N'[students]'))
ALTER TABLE [students] DROP CONSTRAINT [FK_students_card_type]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_students_course_subtypes]') AND parent_object_id = OBJECT_ID(N'[students]'))
ALTER TABLE [students] DROP CONSTRAINT [FK_students_course_subtypes]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_students_student_status]') AND parent_object_id = OBJECT_ID(N'[students]'))
ALTER TABLE [students] DROP CONSTRAINT [FK_students_student_status]
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_students_Status]') AND type = 'D')
BEGIN
ALTER TABLE [students] DROP CONSTRAINT [DF_students_Status]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_students_Balance]') AND type = 'D')
BEGIN
ALTER TABLE [students] DROP CONSTRAINT [DF_students_Balance]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_students_CardInfo]') AND type = 'D')
BEGIN
ALTER TABLE [students] DROP CONSTRAINT [DF_students_CardInfo]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[students]') AND type in (N'U'))
DROP TABLE [students]
GO
/****** Object:  StoredProcedure [dbo].[InsertQuery]    Script Date: 03/25/2012 00:57:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[InsertQuery]') AND type in (N'P', N'PC'))
DROP PROCEDURE [InsertQuery]
GO
/****** Object:  Table [dbo].[course_subtypes]    Script Date: 03/25/2012 00:57:36 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_course_subtypes_course_types]') AND parent_object_id = OBJECT_ID(N'[course_subtypes]'))
ALTER TABLE [course_subtypes] DROP CONSTRAINT [FK_course_subtypes_course_types]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[course_subtypes]') AND type in (N'U'))
DROP TABLE [course_subtypes]
GO
/****** Object:  View [dbo].[v_teacher_wages]    Script Date: 03/25/2012 00:57:39 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_teacher_wages]'))
DROP VIEW [v_teacher_wages]
GO
/****** Object:  View [dbo].[v_teacher_withhold_charge_back]    Script Date: 03/25/2012 00:57:39 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_teacher_withhold_charge_back]'))
DROP VIEW [v_teacher_withhold_charge_back]
GO
/****** Object:  View [dbo].[v_teacher_work_wage]    Script Date: 03/25/2012 00:57:39 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_teacher_work_wage]'))
DROP VIEW [v_teacher_work_wage]
GO
/****** Object:  View [dbo].[v_teacher_age_wage]    Script Date: 03/25/2012 00:57:39 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_teacher_age_wage]'))
DROP VIEW [v_teacher_age_wage]
GO
/****** Object:  View [dbo].[v_teacher_appraisal_award]    Script Date: 03/25/2012 00:57:39 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_teacher_appraisal_award]'))
DROP VIEW [v_teacher_appraisal_award]
GO
/****** Object:  View [dbo].[v_teacher_award]    Script Date: 03/25/2012 00:57:39 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_teacher_award]'))
DROP VIEW [v_teacher_award]
GO
/****** Object:  View [dbo].[v_teacher_basic_wage]    Script Date: 03/25/2012 00:57:39 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_teacher_basic_wage]'))
DROP VIEW [v_teacher_basic_wage]
GO
/****** Object:  View [dbo].[v_teacher_checkin_charge_back]    Script Date: 03/25/2012 00:57:39 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_teacher_checkin_charge_back]'))
DROP VIEW [v_teacher_checkin_charge_back]
GO
/****** Object:  View [dbo].[v_teacher_course_wage]    Script Date: 03/25/2012 00:57:39 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_teacher_course_wage]'))
DROP VIEW [v_teacher_course_wage]
GO
/****** Object:  View [dbo].[v_teacher_full_award]    Script Date: 03/25/2012 00:57:39 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_teacher_full_award]'))
DROP VIEW [v_teacher_full_award]
GO
/****** Object:  View [dbo].[v_teacher_holiday_wage]    Script Date: 03/25/2012 00:57:39 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_teacher_holiday_wage]'))
DROP VIEW [v_teacher_holiday_wage]
GO
/****** Object:  View [dbo].[v_teacher_insurance_wage]    Script Date: 03/25/2012 00:57:39 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_teacher_insurance_wage]'))
DROP VIEW [v_teacher_insurance_wage]
GO
/****** Object:  View [dbo].[v_teacher_job_wage]    Script Date: 03/25/2012 00:57:39 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_teacher_job_wage]'))
DROP VIEW [v_teacher_job_wage]
GO
/****** Object:  View [dbo].[v_teacher_other_award]    Script Date: 03/25/2012 00:57:39 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_teacher_other_award]'))
DROP VIEW [v_teacher_other_award]
GO
/****** Object:  View [dbo].[v_teacher_other_charge_back]    Script Date: 03/25/2012 00:57:39 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_teacher_other_charge_back]'))
DROP VIEW [v_teacher_other_charge_back]
GO
/****** Object:  View [dbo].[v_teacher_other_wage]    Script Date: 03/25/2012 00:57:39 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_teacher_other_wage]'))
DROP VIEW [v_teacher_other_wage]
GO
/****** Object:  View [dbo].[v_teacher_student_award]    Script Date: 03/25/2012 00:57:39 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_teacher_student_award]'))
DROP VIEW [v_teacher_student_award]
GO
/****** Object:  Table [dbo].[student_courses_log]    Script Date: 03/25/2012 00:57:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[student_courses_log]') AND type in (N'U'))
DROP TABLE [student_courses_log]
GO
/****** Object:  Table [dbo].[student_refund]    Script Date: 03/25/2012 00:57:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[student_refund]') AND type in (N'U'))
DROP TABLE [student_refund]
GO
/****** Object:  Table [dbo].[materials]    Script Date: 03/25/2012 00:57:37 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_materials_MaterialCount]') AND type = 'D')
BEGIN
ALTER TABLE [materials] DROP CONSTRAINT [DF_materials_MaterialCount]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[materials]') AND type in (N'U'))
DROP TABLE [materials]
GO
/****** Object:  Table [dbo].[materials_buy]    Script Date: 03/25/2012 00:57:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[materials_buy]') AND type in (N'U'))
DROP TABLE [materials_buy]
GO
/****** Object:  Table [dbo].[materials_cost]    Script Date: 03/25/2012 00:57:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[materials_cost]') AND type in (N'U'))
DROP TABLE [materials_cost]
GO
/****** Object:  Table [dbo].[notice_privilege]    Script Date: 03/25/2012 00:57:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[notice_privilege]') AND type in (N'U'))
DROP TABLE [notice_privilege]
GO
/****** Object:  Table [dbo].[notices]    Script Date: 03/25/2012 00:57:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[notices]') AND type in (N'U'))
DROP TABLE [notices]
GO
/****** Object:  Table [dbo].[software_version]    Script Date: 03/25/2012 00:57:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[software_version]') AND type in (N'U'))
DROP TABLE [software_version]
GO
/****** Object:  Table [dbo].[teacher_signin]    Script Date: 03/25/2012 00:57:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[teacher_signin]') AND type in (N'U'))
DROP TABLE [teacher_signin]
GO
/****** Object:  Table [dbo].[teacher_signin_time]    Script Date: 03/25/2012 00:57:39 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__teacher_s__Creat__753864A1]') AND type = 'D')
BEGIN
ALTER TABLE [teacher_signin_time] DROP CONSTRAINT [DF__teacher_s__Creat__753864A1]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[teacher_signin_time]') AND type in (N'U'))
DROP TABLE [teacher_signin_time]
GO
/****** Object:  Table [dbo].[teacher_student_award]    Script Date: 03/25/2012 00:57:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[teacher_student_award]') AND type in (N'U'))
DROP TABLE [teacher_student_award]
GO
/****** Object:  Table [dbo].[student_status]    Script Date: 03/25/2012 00:57:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[student_status]') AND type in (N'U'))
DROP TABLE [student_status]
GO
/****** Object:  Table [dbo].[student_vacate]    Script Date: 03/25/2012 00:57:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[student_vacate]') AND type in (N'U'))
DROP TABLE [student_vacate]
GO
/****** Object:  Table [dbo].[users]    Script Date: 03/25/2012 00:57:39 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_users_UserType]') AND type = 'D')
BEGIN
ALTER TABLE [users] DROP CONSTRAINT [DF_users_UserType]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[users]') AND type in (N'U'))
DROP TABLE [users]
GO
/****** Object:  Table [dbo].[users_course_privilege]    Script Date: 03/25/2012 00:57:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[users_course_privilege]') AND type in (N'U'))
DROP TABLE [users_course_privilege]
GO
/****** Object:  Table [dbo].[student_cost_log]    Script Date: 03/25/2012 00:57:37 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[student_cost_log]') AND type in (N'U'))
DROP TABLE [student_cost_log]
GO
/****** Object:  Table [dbo].[course_types]    Script Date: 03/25/2012 00:57:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[course_types]') AND type in (N'U'))
DROP TABLE [course_types]
GO
/****** Object:  Table [dbo].[discount_level]    Script Date: 03/25/2012 00:57:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[discount_level]') AND type in (N'U'))
DROP TABLE [discount_level]
GO
/****** Object:  Table [dbo].[financial_accounts]    Script Date: 03/25/2012 00:57:37 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__financial__Incom__7DCDAAA2]') AND type = 'D')
BEGIN
ALTER TABLE [financial_accounts] DROP CONSTRAINT [DF__financial__Incom__7DCDAAA2]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__financial_a__Pay__7EC1CEDB]') AND type = 'D')
BEGIN
ALTER TABLE [financial_accounts] DROP CONSTRAINT [DF__financial_a__Pay__7EC1CEDB]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[financial_accounts]') AND type in (N'U'))
DROP TABLE [financial_accounts]
GO
/****** Object:  Table [dbo].[day_of_week]    Script Date: 03/25/2012 00:57:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[day_of_week]') AND type in (N'U'))
DROP TABLE [day_of_week]
GO
/****** Object:  Table [dbo].[affair_apply]    Script Date: 03/25/2012 00:57:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[affair_apply]') AND type in (N'U'))
DROP TABLE [affair_apply]
GO
/****** Object:  Table [dbo].[card_type]    Script Date: 03/25/2012 00:57:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[card_type]') AND type in (N'U'))
DROP TABLE [card_type]
GO
/****** Object:  Table [dbo].[change_courses]    Script Date: 03/25/2012 00:57:36 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__change_co__Chang__58D1301D]') AND type = 'D')
BEGIN
ALTER TABLE [change_courses] DROP CONSTRAINT [DF__change_co__Chang__58D1301D]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[change_courses]') AND type in (N'U'))
DROP TABLE [change_courses]
GO
/****** Object:  Table [dbo].[charge_type]    Script Date: 03/25/2012 00:57:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[charge_type]') AND type in (N'U'))
DROP TABLE [charge_type]
GO
/****** Object:  Table [dbo].[classrooms]    Script Date: 03/25/2012 00:57:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[classrooms]') AND type in (N'U'))
DROP TABLE [classrooms]
GO
/****** Object:  Table [dbo].[teacher_award]    Script Date: 03/25/2012 00:57:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[teacher_award]') AND type in (N'U'))
DROP TABLE [teacher_award]
GO
/****** Object:  Table [dbo].[teacher_basic_wage]    Script Date: 03/25/2012 00:57:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[teacher_basic_wage]') AND type in (N'U'))
DROP TABLE [teacher_basic_wage]
GO
/****** Object:  Table [dbo].[teacher_charge_back]    Script Date: 03/25/2012 00:57:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[teacher_charge_back]') AND type in (N'U'))
DROP TABLE [teacher_charge_back]
GO
/****** Object:  Table [dbo].[teacher_coefficient]    Script Date: 03/25/2012 00:57:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[teacher_coefficient]') AND type in (N'U'))
DROP TABLE [teacher_coefficient]
GO
/****** Object:  Table [dbo].[teacher_course_salary]    Script Date: 03/25/2012 00:57:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[teacher_course_salary]') AND type in (N'U'))
DROP TABLE [teacher_course_salary]
GO
/****** Object:  Table [dbo].[teacher_salary_adjust]    Script Date: 03/25/2012 00:57:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[teacher_salary_adjust]') AND type in (N'U'))
DROP TABLE [teacher_salary_adjust]
GO
/****** Object:  Table [dbo].[teacher_salary_log]    Script Date: 03/25/2012 00:57:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[teacher_salary_log]') AND type in (N'U'))
DROP TABLE [teacher_salary_log]
GO
/****** Object:  View [dbo].[v_valid_time]    Script Date: 03/25/2012 00:57:39 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_valid_time]'))
DROP VIEW [v_valid_time]
GO
/****** Object:  StoredProcedure [dbo].[InsertTeacher]    Script Date: 03/25/2012 00:57:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[InsertTeacher]') AND type in (N'P', N'PC'))
DROP PROCEDURE [InsertTeacher]
GO
/****** Object:  Table [dbo].[tearchers]    Script Date: 03/25/2012 00:57:39 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_tearchers_Salary]') AND type = 'D')
BEGIN
ALTER TABLE [tearchers] DROP CONSTRAINT [DF_tearchers_Salary]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_tearchers_CreateDate]') AND type = 'D')
BEGIN
ALTER TABLE [tearchers] DROP CONSTRAINT [DF_tearchers_CreateDate]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[tearchers]') AND type in (N'U'))
DROP TABLE [tearchers]
GO
/****** Object:  StoredProcedure [dbo].[InitReport]    Script Date: 03/25/2012 00:57:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[InitReport]') AND type in (N'P', N'PC'))
DROP PROCEDURE [InitReport]
GO
/****** Object:  Table [dbo].[teacher_signin_report]    Script Date: 03/25/2012 00:57:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[teacher_signin_report]') AND type in (N'U'))
DROP TABLE [teacher_signin_report]
GO
/****** Object:  Table [dbo].[teacher_signin]    Script Date: 03/25/2012 00:57:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[teacher_signin]') AND type in (N'U'))
BEGIN
CREATE TABLE [teacher_signin](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TeacherID] [int] NOT NULL,
	[SigninTime] [datetime] NOT NULL,
	[DayOfWeek] [int] NOT NULL,
	[SRangeOne] [datetime] NULL,
	[ERangeOfOne] [datetime] NULL,
	[SRangeOfTwo] [datetime] NULL,
	[ERangeOfTwo] [datetime] NULL,
	[SRangeOfThree] [datetime] NULL,
	[ERangeOfThree] [datetime] NULL,
	[CreateDate] [datetime] NULL,
 CONSTRAINT [PK_TEACHER_SIGNIN] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin', N'COLUMN',N'ID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'签到标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin', @level2type=N'COLUMN',@level2name=N'ID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin', N'COLUMN',N'TeacherID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'教师标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin', @level2type=N'COLUMN',@level2name=N'TeacherID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin', N'COLUMN',N'SigninTime'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'签到时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin', @level2type=N'COLUMN',@level2name=N'SigninTime'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin', N'COLUMN',N'DayOfWeek'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'星期标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin', @level2type=N'COLUMN',@level2name=N'DayOfWeek'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin', N'COLUMN',N'SRangeOne'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'区间1起始' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin', @level2type=N'COLUMN',@level2name=N'SRangeOne'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin', N'COLUMN',N'ERangeOfOne'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'区间1终止' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin', @level2type=N'COLUMN',@level2name=N'ERangeOfOne'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin', N'COLUMN',N'SRangeOfTwo'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'区间2起始' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin', @level2type=N'COLUMN',@level2name=N'SRangeOfTwo'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin', N'COLUMN',N'ERangeOfTwo'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'区间2终止' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin', @level2type=N'COLUMN',@level2name=N'ERangeOfTwo'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin', N'COLUMN',N'SRangeOfThree'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'区间3起始' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin', @level2type=N'COLUMN',@level2name=N'SRangeOfThree'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin', N'COLUMN',N'ERangeOfThree'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'区间3终止' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin', @level2type=N'COLUMN',@level2name=N'ERangeOfThree'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin', N'COLUMN',N'CreateDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin', @level2type=N'COLUMN',@level2name=N'CreateDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'教师签到表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin'
GO
/****** Object:  Table [dbo].[teacher_signin_report]    Script Date: 03/25/2012 00:57:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[teacher_signin_report]') AND type in (N'U'))
BEGIN
CREATE TABLE [teacher_signin_report](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TeacherID] [int] NULL,
	[TeacherName] [varchar](50) NULL,
	[SigninDate] [datetime] NULL,
	[DayOfWeek] [varchar](20) NULL,
	[STimeOne] [datetime] NULL,
	[ETimeOne] [datetime] NULL,
	[STimeTwo] [datetime] NULL,
	[ETimeTwo] [datetime] NULL,
	[STimeThree] [datetime] NULL,
	[ETimeThree] [datetime] NULL,
	[Leave] [numeric](10, 1) NULL,
	[SickLeave] [numeric](10, 1) NULL,
	[GoOut] [numeric](10, 1) NULL,
	[BeLate] [int] NULL,
	[LeaveEarly] [int] NULL,
	[ShouldSign] [int] NULL,
	[UnSign] [int] NULL,
	[Remark] [varchar](200) NULL,
	[Operator] [varchar](50) NULL,
 CONSTRAINT [PK_TEACHER_SIGNIN_REPORT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin_report', N'COLUMN',N'ID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'报表标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin_report', @level2type=N'COLUMN',@level2name=N'ID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin_report', N'COLUMN',N'TeacherID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'教师标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin_report', @level2type=N'COLUMN',@level2name=N'TeacherID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin_report', N'COLUMN',N'TeacherName'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'教师名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin_report', @level2type=N'COLUMN',@level2name=N'TeacherName'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin_report', N'COLUMN',N'SigninDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'考勤日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin_report', @level2type=N'COLUMN',@level2name=N'SigninDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin_report', N'COLUMN',N'DayOfWeek'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'星期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin_report', @level2type=N'COLUMN',@level2name=N'DayOfWeek'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin_report', N'COLUMN',N'STimeOne'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'上班时间1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin_report', @level2type=N'COLUMN',@level2name=N'STimeOne'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin_report', N'COLUMN',N'ETimeOne'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'下班时间1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin_report', @level2type=N'COLUMN',@level2name=N'ETimeOne'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin_report', N'COLUMN',N'STimeTwo'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'上班时间2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin_report', @level2type=N'COLUMN',@level2name=N'STimeTwo'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin_report', N'COLUMN',N'ETimeTwo'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'下班时间2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin_report', @level2type=N'COLUMN',@level2name=N'ETimeTwo'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin_report', N'COLUMN',N'STimeThree'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'上班时间3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin_report', @level2type=N'COLUMN',@level2name=N'STimeThree'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin_report', N'COLUMN',N'ETimeThree'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'下班时间3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin_report', @level2type=N'COLUMN',@level2name=N'ETimeThree'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin_report', N'COLUMN',N'Leave'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'事假' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin_report', @level2type=N'COLUMN',@level2name=N'Leave'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin_report', N'COLUMN',N'SickLeave'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'病假' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin_report', @level2type=N'COLUMN',@level2name=N'SickLeave'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin_report', N'COLUMN',N'GoOut'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'外出' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin_report', @level2type=N'COLUMN',@level2name=N'GoOut'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin_report', N'COLUMN',N'BeLate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'迟到' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin_report', @level2type=N'COLUMN',@level2name=N'BeLate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin_report', N'COLUMN',N'LeaveEarly'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'早退' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin_report', @level2type=N'COLUMN',@level2name=N'LeaveEarly'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin_report', N'COLUMN',N'ShouldSign'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'应签到' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin_report', @level2type=N'COLUMN',@level2name=N'ShouldSign'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin_report', N'COLUMN',N'UnSign'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'未签到' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin_report', @level2type=N'COLUMN',@level2name=N'UnSign'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin_report', N'COLUMN',N'Remark'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin_report', @level2type=N'COLUMN',@level2name=N'Remark'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin_report', N'COLUMN',N'Operator'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'经办人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin_report', @level2type=N'COLUMN',@level2name=N'Operator'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin_report', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'教师签到报表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin_report'
GO



/****** Object:  View [dbo].[v_valid_time]    Script Date: 03/25/2012 00:57:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_valid_time]'))
EXEC dbo.sp_executesql @statement = N'
/*==============================================================*/
/* View: v_valid_time                                           */
/*==============================================================*/
create view [v_valid_time] as
select TeacherID, DayOfWeek, CreateDate, 
   case when SRangeOne is not null then
    dateadd(MINUTE,-30,cast(CONVERT(varchar(12) , GETDATE(), 23) + '' '' + CONVERT(varchar(12) , SRangeOne, 108) as smalldatetime))
   else
    null
    end 
   as SRangeOfOne,
   case when ERangeOfOne is not null then
    dateadd(MINUTE,60,cast(CONVERT(varchar(12) , GETDATE(), 23) + '' '' + CONVERT(varchar(12) , ERangeOfOne, 108) as smalldatetime))
   else
    null
    end 
   as ERangeOfOne,
   case when SRangeOfTwo is not null then
   dateadd(MINUTE,-30,cast(CONVERT(varchar(12) , GETDATE(), 23) + '' '' + CONVERT(varchar(12) , SRangeOfTwo, 108) as smalldatetime))
   else
    null
    end 
   as SRangeOfTwo,
   case when ERangeOfTwo is not null then
   dateadd(MINUTE,60,cast(CONVERT(varchar(12) , GETDATE(), 23) + '' '' + CONVERT(varchar(12) , ERangeOfTwo, 108) as smalldatetime))
   else
    null
    end 
   as ERangeOfTwo,
   case when SRangeOfThree is not null then
   dateadd(MINUTE,-30,cast(CONVERT(varchar(12) , GETDATE(), 23) + '' '' + CONVERT(varchar(12) , SRangeOfThree, 108) as smalldatetime))
   else
    null
    end 
   as SRangeOfThree,
   case when ERangeOfThree is not null then
   dateadd(MINUTE,60,cast(CONVERT(varchar(12) , GETDATE(), 23) + '' '' + CONVERT(varchar(12) , ERangeOfThree, 108) as smalldatetime))
   else
    null
    end 
   as ERangeOfThree
from teacher_signin a where a.ID in (
select ID from (
select MAX(ID) ID, TeacherID, CreateDate from teacher_signin
group by TeacherID, CreateDate
) t
)
'
GO
/****** Object:  StoredProcedure [dbo].[InitReport]    Script Date: 03/25/2012 00:57:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[InitReport]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

create procedure [InitReport] as
DECLARE @BeginDate datetime,
		@EndDate datetime,
		@CheckDate datetime,
		@TeacherID int,
		@TeacherName varchar(50),
		@EXECUTE_SQL nvarchar(4000),
		@For int,
		@TeacherReportCount int
begin
	SELECT @BeginDate=(SELECT CONVERT(CHAR(10),DATEADD(dd,-DAY(GETDATE())+1,GETDATE()),111)),
		   @EndDate=(SELECT CONVERT(CHAR(10),DATEADD(ms,-3,DATEADD(mm,DATEDIFF(m,0,getdate())+1,0)),111)),
		   @EXECUTE_SQL='''',
		   @For=0,
		   @TeacherReportCount=0
		   
DECLARE CursorTeacher CURSOR FOR SELECT ID, Name FROM tearchers
OPEN CursorTeacher 
FETCH NEXT FROM CursorTeacher INTO @TeacherID, @TeacherName
WHILE @@FETCH_STATUS=0
begin
	SET @CheckDate=@BeginDate
	WHILE (@CheckDate<=@EndDate)
		BEGIN
		select @TeacherReportCount=COUNT(0) from teacher_signin_report where TeacherID = @TeacherID and DATEDIFF(day, @CheckDate, SigninDate) = 0
		if (@TeacherReportCount = 0)
			SELECT @EXECUTE_SQL=@EXECUTE_SQL+''INSERT INTO teacher_signin_report (TeacherID,TeacherName,SigninDate,DayOfWeek) SELECT ''
				+CAST(@TeacherID AS nvarchar(20))+'',''
				+''''''''+@TeacherName+'''''',''
				+''''''''+CONVERT(nchar(10),@CheckDate,121)+'''''',''
				+''''''''+DATENAME(weekday,@CheckDate)+''''''''+CHAR(10),
			@For=@For+1
			--IF (@For%40)=0  --每40行保存一次，根据实际的@EXECUTE_SQL长度来调试多少行。
			--BEGIN
				EXECUTE (@EXECUTE_SQL)
				SET @EXECUTE_SQL=''''
			--END
		SET @CheckDate=DATEADD(day,1,@CheckDate)
	END
	FETCH NEXT FROM CursorTeacher INTO @TeacherID,@TeacherName
end
CLOSE CursorTeacher
DEALLOCATE CursorTeacher
IF(@EXECUTE_SQL<>'''') EXECUTE (@EXECUTE_SQL)  --判断@EXECUTE_SQL是否已经执行完成
end
' 
END
GO
/****** Object:  Table [dbo].[tearchers]    Script Date: 03/25/2012 00:57:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[tearchers]') AND type in (N'U'))
BEGIN
CREATE TABLE [tearchers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NULL,
	[Phone] [nvarchar](50) NULL,
	[CardNo] [nvarchar](50) NULL,
	[Sex] [nchar](1) NULL,
	[Address] [nvarchar](50) NULL,
	[Salary] [int] NOT NULL CONSTRAINT [DF_tearchers_Salary]  DEFAULT ((0)),
	[Password] [varchar](50) NULL,
	[BirthDay] [datetime] NULL,
	[Ethnic] [varchar](20) NULL,
	[Hometown] [varchar](20) NULL,
	[GraduationTime] [datetime] NULL,
	[Degree] [varchar](20) NULL,
	[School] [varchar](50) NULL,
	[Professional] [varchar](50) NULL,
	[EntryDate] [datetime] NULL,
	[CreateDate] [datetime] NULL CONSTRAINT [DF_tearchers_CreateDate]  DEFAULT (getdate()),
	[Operator] [varchar](50) NULL,
 CONSTRAINT [PK_tearchers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[InsertTeacher]    Script Date: 03/25/2012 00:57:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[InsertTeacher]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [InsertTeacher]
(
	@Name nvarchar(20),
	@Phone nvarchar(50),
	@CardNo nvarchar(50),
	@Sex nchar(1),
	@Address nvarchar(50),
	@Salary int,
	@Password varchar(50),
	@BirthDay datetime,
	@Ethnic varchar(20),
	@Hometown varchar(20),
	@GraduationTime datetime,
	@Degree varchar(20),
	@School varchar(50),
	@Professional varchar(50),
	@Operator varchar(50),
	@EntryDate datetime
)
AS
	SET NOCOUNT OFF;
INSERT INTO tearchers
                (Name, Phone, CardNo, Sex, Address, Salary, Password, BirthDay, Ethnic, Hometown, GraduationTime, Degree, School, 
                Professional, CreateDate, Operator, EntryDate)
VALUES   (@Name,@Phone,@CardNo,@Sex,@Address,@Salary,@Password,@BirthDay,@Ethnic,@Hometown,@GraduationTime,@Degree,@School,@Professional,getdate(),@Operator,@EntryDate);
	
SELECT ID FROM tearchers WHERE (ID = SCOPE_IDENTITY())' 
END
GO
/****** Object:  Trigger [init_report_with_teachers]    Script Date: 03/25/2012 00:57:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[init_report_with_teachers]'))
EXEC dbo.sp_executesql @statement = N'

create trigger [init_report_with_teachers] on [tearchers] after insert as
begin
    exec InitReport; 
end
'
GO
/****** Object:  Table [dbo].[teacher_salary_log]    Script Date: 03/25/2012 00:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[teacher_salary_log]') AND type in (N'U'))
BEGIN
CREATE TABLE [teacher_salary_log](
	[LogID] [int] IDENTITY(1,1) NOT NULL,
	[TeacherID] [int] NOT NULL,
	[ShouldWages] [money] NULL,
	[RealWages] [money] NULL,
	[CreateDate] [datetime] NOT NULL,
	[Operator] [varchar](50) NOT NULL,
	[TeacherName] [varchar](50) NULL,
	[CheckDate] [datetime] NULL,
 CONSTRAINT [PK_TEACHER_SALARY_LOG] PRIMARY KEY CLUSTERED 
(
	[LogID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_salary_log', N'COLUMN',N'LogID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'记录标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_salary_log', @level2type=N'COLUMN',@level2name=N'LogID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_salary_log', N'COLUMN',N'TeacherID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'教师标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_salary_log', @level2type=N'COLUMN',@level2name=N'TeacherID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_salary_log', N'COLUMN',N'ShouldWages'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'应发工资' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_salary_log', @level2type=N'COLUMN',@level2name=N'ShouldWages'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_salary_log', N'COLUMN',N'RealWages'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'实发工资' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_salary_log', @level2type=N'COLUMN',@level2name=N'RealWages'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_salary_log', N'COLUMN',N'CreateDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_salary_log', @level2type=N'COLUMN',@level2name=N'CreateDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_salary_log', N'COLUMN',N'Operator'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'经办人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_salary_log', @level2type=N'COLUMN',@level2name=N'Operator'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_salary_log', N'COLUMN',N'TeacherName'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'签收人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_salary_log', @level2type=N'COLUMN',@level2name=N'TeacherName'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_salary_log', N'COLUMN',N'CheckDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'签收时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_salary_log', @level2type=N'COLUMN',@level2name=N'CheckDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_salary_log', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'教师工资记录表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_salary_log'
GO
/****** Object:  Table [dbo].[teacher_salary_adjust]    Script Date: 03/25/2012 00:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[teacher_salary_adjust]') AND type in (N'U'))
BEGIN
CREATE TABLE [teacher_salary_adjust](
	[AdjustId] [int] IDENTITY(1,1) NOT NULL,
	[TeacherId] [int] NOT NULL,
	[AdjustDate] [datetime] NOT NULL,
	[NewSalary] [int] NOT NULL
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[teacher_course_salary]    Script Date: 03/25/2012 00:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[teacher_course_salary]') AND type in (N'U'))
BEGIN
CREATE TABLE [teacher_course_salary](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LogID] [int] NOT NULL,
	[CourseType] [varchar](50) NOT NULL,
	[CourseNum] [int] NOT NULL,
	[StandardPrice] [money] NOT NULL,
	[ActualPrice] [money] NOT NULL,
	[CourseAmount] [money] NOT NULL,
	[Remark] [varchar](200) NULL,
 CONSTRAINT [PK_TEACHER_COURSE_SALARY] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_course_salary', N'COLUMN',N'ID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_course_salary', @level2type=N'COLUMN',@level2name=N'ID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_course_salary', N'COLUMN',N'LogID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'记录标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_course_salary', @level2type=N'COLUMN',@level2name=N'LogID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_course_salary', N'COLUMN',N'CourseType'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'课程类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_course_salary', @level2type=N'COLUMN',@level2name=N'CourseType'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_course_salary', N'COLUMN',N'CourseNum'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'上课次数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_course_salary', @level2type=N'COLUMN',@level2name=N'CourseNum'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_course_salary', N'COLUMN',N'StandardPrice'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'标准单价' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_course_salary', @level2type=N'COLUMN',@level2name=N'StandardPrice'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_course_salary', N'COLUMN',N'ActualPrice'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'实际单价' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_course_salary', @level2type=N'COLUMN',@level2name=N'ActualPrice'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_course_salary', N'COLUMN',N'CourseAmount'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'课量工资' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_course_salary', @level2type=N'COLUMN',@level2name=N'CourseAmount'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_course_salary', N'COLUMN',N'Remark'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_course_salary', @level2type=N'COLUMN',@level2name=N'Remark'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_course_salary', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'教师课量工资表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_course_salary'
GO
/****** Object:  Table [dbo].[teacher_coefficient]    Script Date: 03/25/2012 00:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[teacher_coefficient]') AND type in (N'U'))
BEGIN
CREATE TABLE [teacher_coefficient](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LogID] [int] NOT NULL,
	[Coefficient] [float] NOT NULL,
 CONSTRAINT [PK_TEACHER_COEFFICIENT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_coefficient', N'COLUMN',N'ID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_coefficient', @level2type=N'COLUMN',@level2name=N'ID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_coefficient', N'COLUMN',N'LogID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'记录标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_coefficient', @level2type=N'COLUMN',@level2name=N'LogID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_coefficient', N'COLUMN',N'Coefficient'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'系数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_coefficient', @level2type=N'COLUMN',@level2name=N'Coefficient'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_coefficient', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'教师系数表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_coefficient'
GO
/****** Object:  Table [dbo].[teacher_charge_back]    Script Date: 03/25/2012 00:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[teacher_charge_back]') AND type in (N'U'))
BEGIN
CREATE TABLE [teacher_charge_back](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LogID] [int] NOT NULL,
	[ChargeBackName] [varchar](50) NOT NULL,
	[ChargeBackType] [varchar](50) NOT NULL,
	[StandardPrice] [money] NOT NULL,
	[ChargeBackNum] [int] NOT NULL,
	[ChargeBackAmount] [money] NOT NULL,
	[Remark] [varchar](200) NULL,
 CONSTRAINT [PK_TEACHER_CHARGE_BACK] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_charge_back', N'COLUMN',N'ID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_charge_back', @level2type=N'COLUMN',@level2name=N'ID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_charge_back', N'COLUMN',N'LogID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'记录标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_charge_back', @level2type=N'COLUMN',@level2name=N'LogID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_charge_back', N'COLUMN',N'ChargeBackName'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'扣款项目' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_charge_back', @level2type=N'COLUMN',@level2name=N'ChargeBackName'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_charge_back', N'COLUMN',N'ChargeBackType'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'扣款类别' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_charge_back', @level2type=N'COLUMN',@level2name=N'ChargeBackType'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_charge_back', N'COLUMN',N'StandardPrice'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'标准单价' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_charge_back', @level2type=N'COLUMN',@level2name=N'StandardPrice'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_charge_back', N'COLUMN',N'ChargeBackNum'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'数量' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_charge_back', @level2type=N'COLUMN',@level2name=N'ChargeBackNum'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_charge_back', N'COLUMN',N'ChargeBackAmount'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_charge_back', @level2type=N'COLUMN',@level2name=N'ChargeBackAmount'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_charge_back', N'COLUMN',N'Remark'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_charge_back', @level2type=N'COLUMN',@level2name=N'Remark'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_charge_back', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'教师扣款表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_charge_back'
GO
/****** Object:  Table [dbo].[teacher_basic_wage]    Script Date: 03/25/2012 00:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[teacher_basic_wage]') AND type in (N'U'))
BEGIN
CREATE TABLE [teacher_basic_wage](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LogID] [int] NOT NULL,
	[WageType] [varchar](20) NOT NULL,
	[WageStandard] [money] NOT NULL,
	[WageNum] [int] NOT NULL,
	[WageAmount] [money] NOT NULL,
	[Remark] [varchar](200) NULL,
 CONSTRAINT [PK_TEACHER_BASIC_WAGE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_basic_wage', N'COLUMN',N'ID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_basic_wage', @level2type=N'COLUMN',@level2name=N'ID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_basic_wage', N'COLUMN',N'LogID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'记录标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_basic_wage', @level2type=N'COLUMN',@level2name=N'LogID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_basic_wage', N'COLUMN',N'WageType'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'工资项目' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_basic_wage', @level2type=N'COLUMN',@level2name=N'WageType'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_basic_wage', N'COLUMN',N'WageStandard'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'标准' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_basic_wage', @level2type=N'COLUMN',@level2name=N'WageStandard'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_basic_wage', N'COLUMN',N'WageNum'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'数量' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_basic_wage', @level2type=N'COLUMN',@level2name=N'WageNum'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_basic_wage', N'COLUMN',N'WageAmount'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_basic_wage', @level2type=N'COLUMN',@level2name=N'WageAmount'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_basic_wage', N'COLUMN',N'Remark'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_basic_wage', @level2type=N'COLUMN',@level2name=N'Remark'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_basic_wage', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'教师基本工资表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_basic_wage'
GO
/****** Object:  Table [dbo].[teacher_award]    Script Date: 03/25/2012 00:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[teacher_award]') AND type in (N'U'))
BEGIN
CREATE TABLE [teacher_award](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LogID] [int] NOT NULL,
	[AwardName] [varchar](50) NOT NULL,
	[StandardPrice] [money] NOT NULL,
	[ActualPrice] [money] NOT NULL,
	[AwardNum] [int] NOT NULL,
	[AwardAmount] [money] NOT NULL,
	[Remark] [varchar](200) NULL,
 CONSTRAINT [PK_TEACHER_AWARD] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_award', N'COLUMN',N'ID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_award', @level2type=N'COLUMN',@level2name=N'ID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_award', N'COLUMN',N'LogID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'记录标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_award', @level2type=N'COLUMN',@level2name=N'LogID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_award', N'COLUMN',N'AwardName'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'奖励项目' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_award', @level2type=N'COLUMN',@level2name=N'AwardName'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_award', N'COLUMN',N'StandardPrice'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'标准单价' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_award', @level2type=N'COLUMN',@level2name=N'StandardPrice'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_award', N'COLUMN',N'ActualPrice'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'实际单价' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_award', @level2type=N'COLUMN',@level2name=N'ActualPrice'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_award', N'COLUMN',N'AwardNum'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'数量' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_award', @level2type=N'COLUMN',@level2name=N'AwardNum'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_award', N'COLUMN',N'AwardAmount'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_award', @level2type=N'COLUMN',@level2name=N'AwardAmount'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_award', N'COLUMN',N'Remark'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_award', @level2type=N'COLUMN',@level2name=N'Remark'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_award', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'教师奖励工资表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_award'
GO
/****** Object:  Table [dbo].[classrooms]    Script Date: 03/25/2012 00:57:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[classrooms]') AND type in (N'U'))
BEGIN
CREATE TABLE [classrooms](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ClassroomName] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_classrooms] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[charge_type]    Script Date: 03/25/2012 00:57:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[charge_type]') AND type in (N'U'))
BEGIN
CREATE TABLE [charge_type](
	[ChargeTypeID] [int] NOT NULL,
	[ChargeTypeName] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_charge_type] PRIMARY KEY CLUSTERED 
(
	[ChargeTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[change_courses]    Script Date: 03/25/2012 00:57:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[change_courses]') AND type in (N'U'))
BEGIN
CREATE TABLE [change_courses](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [int] NOT NULL,
	[CourseType] [nvarchar](20) NOT NULL,
	[CourseSubtypeName] [nvarchar](20) NOT NULL,
	[CourseName] [nvarchar](50) NOT NULL,
	[ChargeType] [nvarchar](20) NOT NULL,
	[ChargeAmount] [int] NOT NULL,
	[NewCourseType] [nvarchar](20) NOT NULL,
	[NewCourseSubtypeName] [nvarchar](20) NOT NULL,
	[NewCourseName] [nvarchar](50) NOT NULL,
	[NewChargeType] [nvarchar](20) NOT NULL,
	[NewChargeAmount] [int] NOT NULL,
	[ExpireTime] [datetime] NOT NULL,
	[TotalAmount] [int] NULL,
	[SettlementAmount] [int] NULL,
	[InbackAmount] [int] NULL,
	[DiscountLevel] [int] NULL,
	[DiscountReason] [nvarchar](200) NULL,
	[ChangeDate] [datetime] NOT NULL DEFAULT (getdate()),
	[Operator] [varchar](50) NULL,
 CONSTRAINT [PK_CHANGE_COURSES] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'change_courses', N'COLUMN',N'ID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'标识#ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'change_courses', @level2type=N'COLUMN',@level2name=N'ID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'change_courses', N'COLUMN',N'StudentID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'学生标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'change_courses', @level2type=N'COLUMN',@level2name=N'StudentID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'change_courses', N'COLUMN',N'CourseType'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'原课程类别名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'change_courses', @level2type=N'COLUMN',@level2name=N'CourseType'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'change_courses', N'COLUMN',N'CourseSubtypeName'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'原课程科目名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'change_courses', @level2type=N'COLUMN',@level2name=N'CourseSubtypeName'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'change_courses', N'COLUMN',N'CourseName'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'原课程名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'change_courses', @level2type=N'COLUMN',@level2name=N'CourseName'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'change_courses', N'COLUMN',N'ChargeType'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'原课程收费方式' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'change_courses', @level2type=N'COLUMN',@level2name=N'ChargeType'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'change_courses', N'COLUMN',N'ChargeAmount'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'原课程金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'change_courses', @level2type=N'COLUMN',@level2name=N'ChargeAmount'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'change_courses', N'COLUMN',N'NewCourseType'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'新课程类别名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'change_courses', @level2type=N'COLUMN',@level2name=N'NewCourseType'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'change_courses', N'COLUMN',N'NewCourseSubtypeName'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'新课程科目名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'change_courses', @level2type=N'COLUMN',@level2name=N'NewCourseSubtypeName'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'change_courses', N'COLUMN',N'NewCourseName'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'新课程名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'change_courses', @level2type=N'COLUMN',@level2name=N'NewCourseName'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'change_courses', N'COLUMN',N'NewChargeType'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'新课程收费方式' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'change_courses', @level2type=N'COLUMN',@level2name=N'NewChargeType'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'change_courses', N'COLUMN',N'NewChargeAmount'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'新课程金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'change_courses', @level2type=N'COLUMN',@level2name=N'NewChargeAmount'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'change_courses', N'COLUMN',N'ExpireTime'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'新课程到期日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'change_courses', @level2type=N'COLUMN',@level2name=N'ExpireTime'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'change_courses', N'COLUMN',N'TotalAmount'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'总金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'change_courses', @level2type=N'COLUMN',@level2name=N'TotalAmount'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'change_courses', N'COLUMN',N'SettlementAmount'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'结算金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'change_courses', @level2type=N'COLUMN',@level2name=N'SettlementAmount'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'change_courses', N'COLUMN',N'InbackAmount'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'补缴金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'change_courses', @level2type=N'COLUMN',@level2name=N'InbackAmount'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'change_courses', N'COLUMN',N'DiscountLevel'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'折扣等级' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'change_courses', @level2type=N'COLUMN',@level2name=N'DiscountLevel'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'change_courses', N'COLUMN',N'DiscountReason'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'折扣原因' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'change_courses', @level2type=N'COLUMN',@level2name=N'DiscountReason'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'change_courses', N'COLUMN',N'ChangeDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'转班日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'change_courses', @level2type=N'COLUMN',@level2name=N'ChangeDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'change_courses', N'COLUMN',N'Operator'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'经办人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'change_courses', @level2type=N'COLUMN',@level2name=N'Operator'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'change_courses', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'学生转班记录表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'change_courses'
GO
/****** Object:  Table [dbo].[card_type]    Script Date: 03/25/2012 00:57:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[card_type]') AND type in (N'U'))
BEGIN
CREATE TABLE [card_type](
	[CardTypeID] [int] NOT NULL,
	[CardTypeName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_card_type] PRIMARY KEY CLUSTERED 
(
	[CardTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[affair_apply]    Script Date: 03/25/2012 00:57:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[affair_apply]') AND type in (N'U'))
BEGIN
CREATE TABLE [affair_apply](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[ApplyDate] [datetime] NOT NULL,
	[ApplyTitle] [nvarchar](200) NOT NULL,
	[ApplyContent] [nvarchar](500) NULL,
	[Status] [int] NOT NULL,
	[ApprovalContent] [nvarchar](500) NULL,
	[ApproverUserName] [varchar](50) NULL,
	[ApprovalDate] [datetime] NULL,
	[CheckDate] [datetime] NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[day_of_week]    Script Date: 03/25/2012 00:57:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[day_of_week]') AND type in (N'U'))
BEGIN
CREATE TABLE [day_of_week](
	[DayOfWeekValue] [int] NOT NULL,
	[DayOfWeekName] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_day_of_week] PRIMARY KEY CLUSTERED 
(
	[DayOfWeekValue] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[financial_accounts]    Script Date: 03/25/2012 00:57:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[financial_accounts]') AND type in (N'U'))
BEGIN
CREATE TABLE [financial_accounts](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Summary] [varchar](100) NOT NULL,
	[Income] [money] NULL DEFAULT ((0)),
	[Pay] [money] NULL DEFAULT ((0)),
	[Remark] [varchar](200) NULL,
	[CreateDate] [datetime] NOT NULL,
	[Operator] [varchar](50) NOT NULL,
	[AccountType] [int] NOT NULL,
	[CheckUser] [varchar](50) NULL,
	[CheckDate] [datetime] NULL,
 CONSTRAINT [PK_FINANCIAL_ACCOUNTS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'financial_accounts', N'COLUMN',N'ID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'financial_accounts', @level2type=N'COLUMN',@level2name=N'ID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'financial_accounts', N'COLUMN',N'Income'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'收入' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'financial_accounts', @level2type=N'COLUMN',@level2name=N'Income'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'financial_accounts', N'COLUMN',N'Pay'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'支出' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'financial_accounts', @level2type=N'COLUMN',@level2name=N'Pay'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'financial_accounts', N'COLUMN',N'Remark'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'financial_accounts', @level2type=N'COLUMN',@level2name=N'Remark'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'financial_accounts', N'COLUMN',N'CreateDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'financial_accounts', @level2type=N'COLUMN',@level2name=N'CreateDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'financial_accounts', N'COLUMN',N'Operator'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'经办人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'financial_accounts', @level2type=N'COLUMN',@level2name=N'Operator'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'financial_accounts', N'COLUMN',N'AccountType'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'账目类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'financial_accounts', @level2type=N'COLUMN',@level2name=N'AccountType'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'financial_accounts', N'COLUMN',N'CheckUser'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'审核人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'financial_accounts', @level2type=N'COLUMN',@level2name=N'CheckUser'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'financial_accounts', N'COLUMN',N'CheckDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'审核时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'financial_accounts', @level2type=N'COLUMN',@level2name=N'CheckDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'financial_accounts', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'财务账目表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'financial_accounts'
GO
/****** Object:  Table [dbo].[discount_level]    Script Date: 03/25/2012 00:57:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[discount_level]') AND type in (N'U'))
BEGIN
CREATE TABLE [discount_level](
	[DiscountLevel] [int] NOT NULL,
	[DiscountLevelName] [varchar](20) NOT NULL,
 CONSTRAINT [PK_discount_level] PRIMARY KEY CLUSTERED 
(
	[DiscountLevel] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[course_types]    Script Date: 03/25/2012 00:57:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[course_types]') AND type in (N'U'))
BEGIN
CREATE TABLE [course_types](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CourseTypeName] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_courses] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[student_cost_log]    Script Date: 03/25/2012 00:57:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[student_cost_log]') AND type in (N'U'))
BEGIN
CREATE TABLE [student_cost_log](
	[ID] [int] NOT NULL,
	[StudentID] [int] NOT NULL,
	[CourseID] [int] NOT NULL,
	[CostAmount] [int] NOT NULL,
	[CostDate] [datetime] NOT NULL,
	[DiscountLevel] [int] NOT NULL,
	[ActualCostAmount] [int] NOT NULL,
	[DiscountReason] [nvarchar](200) NULL,
	[Operator] [varchar](50) NULL,
	[CourseTimeID] [int] NULL,
	[OldExpireTime] [datetime] NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'student_cost_log', N'COLUMN',N'ID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'消费标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'student_cost_log', @level2type=N'COLUMN',@level2name=N'ID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'student_cost_log', N'COLUMN',N'StudentID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'学生标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'student_cost_log', @level2type=N'COLUMN',@level2name=N'StudentID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'student_cost_log', N'COLUMN',N'CourseID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'课程标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'student_cost_log', @level2type=N'COLUMN',@level2name=N'CourseID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'student_cost_log', N'COLUMN',N'CostAmount'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'消费金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'student_cost_log', @level2type=N'COLUMN',@level2name=N'CostAmount'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'student_cost_log', N'COLUMN',N'CostDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'消费日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'student_cost_log', @level2type=N'COLUMN',@level2name=N'CostDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'student_cost_log', N'COLUMN',N'DiscountLevel'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'折扣等级' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'student_cost_log', @level2type=N'COLUMN',@level2name=N'DiscountLevel'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'student_cost_log', N'COLUMN',N'ActualCostAmount'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'实际消费金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'student_cost_log', @level2type=N'COLUMN',@level2name=N'ActualCostAmount'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'student_cost_log', N'COLUMN',N'DiscountReason'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'打折原因' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'student_cost_log', @level2type=N'COLUMN',@level2name=N'DiscountReason'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'student_cost_log', N'COLUMN',N'Operator'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'经办人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'student_cost_log', @level2type=N'COLUMN',@level2name=N'Operator'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'student_cost_log', N'COLUMN',N'CourseTimeID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'课程时间标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'student_cost_log', @level2type=N'COLUMN',@level2name=N'CourseTimeID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'student_cost_log', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'学生消费历史表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'student_cost_log'
GO
/****** Object:  Table [dbo].[users_course_privilege]    Script Date: 03/25/2012 00:57:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[users_course_privilege]') AND type in (N'U'))
BEGIN
CREATE TABLE [users_course_privilege](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[CourseId] [int] NOT NULL,
 CONSTRAINT [PK_user_course_privilege] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[users]    Script Date: 03/25/2012 00:57:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[users]') AND type in (N'U'))
BEGIN
CREATE TABLE [users](
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[UserType] [int] NOT NULL CONSTRAINT [DF_users_UserType]  DEFAULT ((0))
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[student_vacate]    Script Date: 03/25/2012 00:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[student_vacate]') AND type in (N'U'))
BEGIN
CREATE TABLE [student_vacate](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StudentId] [int] NOT NULL,
	[BeginVacateTime] [datetime] NOT NULL,
	[EndVacateTime] [datetime] NULL
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[student_status]    Script Date: 03/25/2012 00:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[student_status]') AND type in (N'U'))
BEGIN
CREATE TABLE [student_status](
	[StatusID] [int] NOT NULL,
	[StatusName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_student_status] PRIMARY KEY CLUSTERED 
(
	[StatusID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[teacher_student_award]    Script Date: 03/25/2012 00:57:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[teacher_student_award]') AND type in (N'U'))
BEGIN
CREATE TABLE [teacher_student_award](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LogID] [int] NOT NULL,
	[TotalStudent] [int] NOT NULL,
	[ActualStudent] [int] NOT NULL,
	[StandardPrice] [money] NOT NULL,
	[ActualPrice] [money] NOT NULL,
	[Amount] [money] NOT NULL,
 CONSTRAINT [PK_TEACHER_STUDENT_AWARD] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_student_award', N'COLUMN',N'ID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_student_award', @level2type=N'COLUMN',@level2name=N'ID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_student_award', N'COLUMN',N'LogID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'记录标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_student_award', @level2type=N'COLUMN',@level2name=N'LogID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_student_award', N'COLUMN',N'TotalStudent'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'班级总人数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_student_award', @level2type=N'COLUMN',@level2name=N'TotalStudent'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_student_award', N'COLUMN',N'ActualStudent'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'实际出勤人数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_student_award', @level2type=N'COLUMN',@level2name=N'ActualStudent'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_student_award', N'COLUMN',N'StandardPrice'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'标准单价' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_student_award', @level2type=N'COLUMN',@level2name=N'StandardPrice'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_student_award', N'COLUMN',N'ActualPrice'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'实际单价' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_student_award', @level2type=N'COLUMN',@level2name=N'ActualPrice'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_student_award', N'COLUMN',N'Amount'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_student_award', @level2type=N'COLUMN',@level2name=N'Amount'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_student_award', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'教师学生管理奖励表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_student_award'
GO
/****** Object:  Table [dbo].[teacher_signin_time]    Script Date: 03/25/2012 00:57:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[teacher_signin_time]') AND type in (N'U'))
BEGIN
CREATE TABLE [teacher_signin_time](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TeacherID] [int] NOT NULL,
	[DayOfWeek] [int] NULL,
	[BeginTime] [datetime] NOT NULL,
	[EndTime] [datetime] NOT NULL,
	[Range] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL DEFAULT (getdate()),
	[Operator] [varchar](50) NULL,
 CONSTRAINT [PK_TEACHER_SIGNIN_TIME] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin_time', N'COLUMN',N'TeacherID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'教师标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin_time', @level2type=N'COLUMN',@level2name=N'TeacherID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin_time', N'COLUMN',N'DayOfWeek'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'星期标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin_time', @level2type=N'COLUMN',@level2name=N'DayOfWeek'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin_time', N'COLUMN',N'BeginTime'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'开始时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin_time', @level2type=N'COLUMN',@level2name=N'BeginTime'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin_time', N'COLUMN',N'EndTime'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'结束时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin_time', @level2type=N'COLUMN',@level2name=N'EndTime'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin_time', N'COLUMN',N'Range'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'区间标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin_time', @level2type=N'COLUMN',@level2name=N'Range'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin_time', N'COLUMN',N'CreateDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin_time', @level2type=N'COLUMN',@level2name=N'CreateDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin_time', N'COLUMN',N'Operator'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'经办人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin_time', @level2type=N'COLUMN',@level2name=N'Operator'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'teacher_signin_time', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'教师考勤时间表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'teacher_signin_time'
GO
/****** Object:  Trigger [init_report_with_signin]    Script Date: 03/25/2012 00:57:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[init_report_with_signin]'))
EXEC dbo.sp_executesql @statement = N'

create trigger [init_report_with_signin] on [teacher_signin] 
after insert as
begin
--定义变量    
declare @TeacherID int, @SigninTime datetime, @iBeLate int, @iLeaveEarly int, 
@STimeOne datetime, @ETimeOne datetime, @STimeTwo datetime, @ETimeTwo datetime, @STimeThree datetime, @ETimeThree datetime,
@uSTimeOne datetime, @uETimeOne datetime, @uSTimeTwo datetime, @uETimeTwo datetime, @uSTimeThree datetime, @uETimeThree datetime;
exec InitReport;
set @iBeLate = 0;
set @iLeaveEarly = 0;
select @TeacherID = TeacherID, @SigninTime = SigninTime from inserted;
update teacher_signin_report 
set teacher_signin_report.STimeOne = (
		select (
			case when v_valid_time.SRangeOfOne IS not null then
			(select top 1 teacher_signin.SigninTime from teacher_signin
				where teacher_signin.SigninTime >= v_valid_time.SRangeOfOne 
				and teacher_signin.SigninTime <= v_valid_time.ERangeOfOne
				and teacher_signin.TeacherID = v_valid_time.TeacherID
			)
			else
				null
			end
		) as STimeOne from v_valid_time
		where v_valid_time.TeacherID = @TeacherID and (DATEDIFF(day, @SigninTime, v_valid_time.CreateDate) = 0)
	), 
	teacher_signin_report.ETimeOne = (
		select (
			case when v_valid_time.ERangeOfOne IS not null then
			(select top 1 teacher_signin.SigninTime from teacher_signin
				where teacher_signin.SigninTime >= v_valid_time.SRangeOfOne 
				and teacher_signin.SigninTime <= v_valid_time.ERangeOfOne
				and teacher_signin.SigninTime <> (
					select top 1 teacher_signin.SigninTime from teacher_signin
						where teacher_signin.SigninTime >= v_valid_time.SRangeOfOne and teacher_signin.SigninTime <= v_valid_time.ERangeOfOne
						and teacher_signin.TeacherID = v_valid_time.TeacherID
				)
				and teacher_signin.TeacherID = v_valid_time.TeacherID
				order by teacher_signin.SigninTime desc
			)
			else
				null
			end
		)  as ETimeOne from v_valid_time
		where v_valid_time.TeacherID = @TeacherID and (DATEDIFF(day, @SigninTime, v_valid_time.CreateDate) = 0)
	),
    teacher_signin_report.STimeTwo = (
		select (
			case when v_valid_time.SRangeOfTwo IS not null then
			(select top 1 teacher_signin.SigninTime from teacher_signin
				where teacher_signin.SigninTime >= v_valid_time.SRangeOfTwo and teacher_signin.SigninTime <= v_valid_time.ERangeOfTwo
				and teacher_signin.TeacherID = v_valid_time.TeacherID
			)
			else
				null
			end
		)  as STimeTwo from v_valid_time
		where v_valid_time.TeacherID = @TeacherID and (DATEDIFF(day, @SigninTime, v_valid_time.CreateDate) = 0)
    ), 
    teacher_signin_report.ETimeTwo = (
		select (
			case when v_valid_time.ERangeOfTwo IS not null then
				(select top 1 teacher_signin.SigninTime from teacher_signin
					where teacher_signin.SigninTime >= v_valid_time.SRangeOfTwo and teacher_signin.SigninTime <= v_valid_time.ERangeOfTwo
					and teacher_signin.SigninTime <> (
						select top 1 teacher_signin.SigninTime from teacher_signin
						where teacher_signin.SigninTime >= v_valid_time.SRangeOfTwo and teacher_signin.SigninTime <= v_valid_time.ERangeOfTwo
						and teacher_signin.TeacherID = v_valid_time.TeacherID
					)
					and teacher_signin.TeacherID = v_valid_time.TeacherID
					order by teacher_signin.SigninTime desc
				)
			else
				null
			end
		) as ETimeTwo from v_valid_time
		where v_valid_time.TeacherID = @TeacherID and (DATEDIFF(day, @SigninTime, v_valid_time.CreateDate) = 0)
    ),
    teacher_signin_report.STimeThree = (
		select (
			case when v_valid_time.SRangeOfThree IS not null then
			(select top 1 teacher_signin.SigninTime from teacher_signin
				where teacher_signin.SigninTime >= v_valid_time.SRangeOfThree and teacher_signin.SigninTime <= v_valid_time.ERangeOfThree
				and teacher_signin.TeacherID = v_valid_time.TeacherID
			)
			else
				null
			end
		)  as STimeThree from v_valid_time
		where v_valid_time.TeacherID = @TeacherID and (DATEDIFF(day, @SigninTime, v_valid_time.CreateDate) = 0)
    ), 
    teacher_signin_report.ETimeThree = (
		select (
			case when v_valid_time.ERangeOfThree IS not null then
				(select top 1 teacher_signin.SigninTime from teacher_signin
					where teacher_signin.SigninTime >= v_valid_time.SRangeOfThree and teacher_signin.SigninTime <= v_valid_time.ERangeOfThree
					and teacher_signin.SigninTime <> (
						select top 1 teacher_signin.SigninTime from teacher_signin
						where teacher_signin.SigninTime >= v_valid_time.SRangeOfThree and teacher_signin.SigninTime <= v_valid_time.ERangeOfThree
						and teacher_signin.TeacherID = v_valid_time.TeacherID
					)
					and teacher_signin.TeacherID = v_valid_time.TeacherID
					order by teacher_signin.SigninTime desc
				)
			else
				null
			end
		)  as ETimeThree  from v_valid_time
		where v_valid_time.TeacherID = @TeacherID and (DATEDIFF(day, @SigninTime, v_valid_time.CreateDate) = 0)
    )
where teacher_signin_report.TeacherID = @TeacherID
and (DATEDIFF(day, @SigninTime, SigninDate) = 0);


select @STimeOne = v_valid_time.SRangeOfOne,@ETimeOne = v_valid_time.ERangeOfOne,
	   @STimeTwo = v_valid_time.SRangeOfTwo,@ETimeTwo = v_valid_time.ERangeOfTwo,
	   @STimeThree = v_valid_time.SRangeOfThree,@ETimeThree = v_valid_time.ERangeOfThree
 from v_valid_time where v_valid_time.TeacherID = @TeacherID and (DATEDIFF(DAY, @SigninTime, v_valid_time.CreateDate) = 0);
 
 select @uSTimeOne = teacher_signin_report.STimeOne,@uETimeOne = teacher_signin_report.ETimeOne,
	   @uSTimeTwo = teacher_signin_report.STimeTwo,@uETimeTwo = teacher_signin_report.ETimeTwo,
	   @uSTimeThree = teacher_signin_report.STimeThree,@uETimeThree = teacher_signin_report.ETimeThree
 from teacher_signin_report where teacher_signin_report.TeacherID = @TeacherID and (DATEDIFF(DAY, @SigninTime, teacher_signin_report.SigninDate) = 0);
 
 if (@STimeOne is not null) and (@uSTimeOne is not null) and (datediff(MINUTE,dateadd(MINUTE,30,@STimeOne),@uSTimeOne)>0)
	select @iBeLate = @iBeLate + datediff(MINUTE,dateadd(MINUTE,30,@STimeOne),@uSTimeOne)
 if (@ETimeOne is not null) and (@uETimeOne is not null) and (datediff(MINUTE,@uETimeOne,dateadd(MINUTE,-60,@ETimeOne))>0)
	select @iLeaveEarly = @iLeaveEarly + datediff(MINUTE,@uETimeOne,dateadd(MINUTE,-60,@ETimeOne))
 if (@STimeTwo is not null) and (@uSTimeTwo is not null) and (datediff(MINUTE,dateadd(MINUTE,30,@STimeTwo),@uSTimeTwo)>0)
	select @iBeLate = @iBeLate + datediff(MINUTE,dateadd(MINUTE,30,@STimeTwo),@uSTimeTwo)
 if (@ETimeTwo is not null) and (@uETimeTwo is not null) and (datediff(MINUTE,@uETimeTwo,dateadd(MINUTE,-60,@ETimeTwo))>0)
	select @iLeaveEarly = @iLeaveEarly + datediff(MINUTE,@uETimeTwo,dateadd(MINUTE,-60,@ETimeTwo))
 if (@STimeThree is not null) and (@uSTimeThree is not null) and (datediff(MINUTE,dateadd(MINUTE,30,@STimeThree),@uSTimeThree)>0)
	select @iBeLate = @iBeLate + datediff(MINUTE,dateadd(MINUTE,30,@STimeThree),@uSTimeThree)
 if (@ETimeThree is not null) and (@uETimeThree is not null) and (datediff(MINUTE,@uETimeThree,dateadd(MINUTE,-60,@ETimeThree))>0)
	select @iLeaveEarly = @iLeaveEarly + datediff(MINUTE,@uETimeThree,dateadd(MINUTE,-60,@ETimeThree))

update teacher_signin_report 
set teacher_signin_report.BeLate = (
	case when @iBeLate = 0 then
		null
	else
		ABS(@iBeLate)
	end
),
teacher_signin_report.LeaveEarly = (
	case when @iLeaveEarly = 0 then
		null
	else
		ABS(@iLeaveEarly)
	end
)
where teacher_signin_report.TeacherID = @TeacherID
and (DATEDIFF(day, @SigninTime, SigninDate) = 0);

end
'
GO
/****** Object:  Table [dbo].[software_version]    Script Date: 03/25/2012 00:57:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[software_version]') AND type in (N'U'))
BEGIN
CREATE TABLE [software_version](
	[SoftwareName] [nvarchar](50) NOT NULL,
	[SoftwareVersion] [nvarchar](50) NOT NULL,
	[Remark] [nvarchar](100)
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[notices]    Script Date: 03/25/2012 00:57:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[notices]') AND type in (N'U'))
BEGIN
CREATE TABLE [notices](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[PublishDate] [datetime] NOT NULL,
	[NoticeTitle] [nvarchar](200) NOT NULL,
	[NoticeContent] [nvarchar](500) NULL,
 CONSTRAINT [PK_notices] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[notice_privilege]    Script Date: 03/25/2012 00:57:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[notice_privilege]') AND type in (N'U'))
BEGIN
CREATE TABLE [notice_privilege](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NoticeID] [int] NOT NULL,
	[AllowedUserName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_notice_privilege] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[materials_cost]    Script Date: 03/25/2012 00:57:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[materials_cost]') AND type in (N'U'))
BEGIN
CREATE TABLE [materials_cost](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [int] NOT NULL,
	[MaterialID] [int] NOT NULL,
	[MaterialPrice] [int] NOT NULL,
	[BuyCount] [int] NOT NULL,
	[TotalCost] [int] NOT NULL,
	[BuyTime] [datetime] NULL,
	[Operator] [varchar](50) NULL,
 CONSTRAINT [PK_materials_cost] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[materials_buy]    Script Date: 03/25/2012 00:57:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[materials_buy]') AND type in (N'U'))
BEGIN
CREATE TABLE [materials_buy](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaterialId] [int] NOT NULL,
	[BuyAmount] [int] NOT NULL,
	[TotalCost] [int] NOT NULL,
	[ActualPay] [int] NOT NULL,
	[Remark] [nvarchar](200) NULL,
	[BuyDate] [datetime] NOT NULL,
	[Operator] [varchar](50) NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[materials]    Script Date: 03/25/2012 00:57:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[materials]') AND type in (N'U'))
BEGIN
CREATE TABLE [materials](
	[MaterialID] [int] IDENTITY(1,1) NOT NULL,
	[MaterialName] [nvarchar](50) NOT NULL,
	[MaterialPrice] [int] NOT NULL,
	[MaterialCount] [int] NOT NULL CONSTRAINT [DF_materials_MaterialCount]  DEFAULT ((0)),
	[Operator] [varchar](50) NULL,
 CONSTRAINT [PK_materials] PRIMARY KEY CLUSTERED 
(
	[MaterialID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[student_refund]    Script Date: 03/25/2012 00:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[student_refund]') AND type in (N'U'))
BEGIN
CREATE TABLE [student_refund](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [int] NOT NULL,
	[CourseID] [int] NOT NULL,
	[RefundAmount] [int] NOT NULL,
	[RefundDate] [datetime] NOT NULL,
	[RefundReason] [nvarchar](200) NULL,
	[Operator] [varchar](50) NULL,
 CONSTRAINT [PK_student_refund] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[student_courses_log]    Script Date: 03/25/2012 00:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[student_courses_log]') AND type in (N'U'))
BEGIN
CREATE TABLE [student_courses_log](
	[ID] [int] NOT NULL,
	[StudentID] [int] NOT NULL,
	[CourseID] [int] NOT NULL,
	[ExpireTime] [datetime] NOT NULL,
	[Balance] [int] NULL,
	[CourseNum] [int] NULL
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'student_courses_log', N'COLUMN',N'ID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'student_courses_log', @level2type=N'COLUMN',@level2name=N'ID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'student_courses_log', N'COLUMN',N'StudentID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'学生标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'student_courses_log', @level2type=N'COLUMN',@level2name=N'StudentID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'student_courses_log', N'COLUMN',N'CourseID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'课程标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'student_courses_log', @level2type=N'COLUMN',@level2name=N'CourseID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'student_courses_log', N'COLUMN',N'ExpireTime'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'缴费过期时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'student_courses_log', @level2type=N'COLUMN',@level2name=N'ExpireTime'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'student_courses_log', N'COLUMN',N'Balance'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'余额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'student_courses_log', @level2type=N'COLUMN',@level2name=N'Balance'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'student_courses_log', N'COLUMN',N'CourseNum'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'课程数量' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'student_courses_log', @level2type=N'COLUMN',@level2name=N'CourseNum'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'student_courses_log', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'学生课程历史表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'student_courses_log'
GO
/****** Object:  View [dbo].[v_teacher_student_award]    Script Date: 03/25/2012 00:57:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_teacher_student_award]'))
EXEC dbo.sp_executesql @statement = N'
/*==============================================================*/
/* View: v_teacher_student_award                                */
/*==============================================================*/
create view [v_teacher_student_award] as
select
	teacher_student_award.LogID,
   teacher_student_award.Amount
from
   teacher_student_award
'
GO
/****** Object:  View [dbo].[v_teacher_other_wage]    Script Date: 03/25/2012 00:57:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_teacher_other_wage]'))
EXEC dbo.sp_executesql @statement = N'
/*==============================================================*/
/* View: v_teacher_other_wage                                   */
/*==============================================================*/
create view [v_teacher_other_wage] as
select
   teacher_basic_wage.LogID,
   teacher_basic_wage.WageType,
   teacher_basic_wage.WageAmount
from
   teacher_basic_wage
where
   teacher_basic_wage.WageType = ''其他补贴'';
'
GO
/****** Object:  View [dbo].[v_teacher_other_charge_back]    Script Date: 03/25/2012 00:57:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_teacher_other_charge_back]'))
EXEC dbo.sp_executesql @statement = N'
/*==============================================================*/
/* View: v_teacher_other_charge_back                            */
/*==============================================================*/
create view [v_teacher_other_charge_back] as
select
teacher_charge_back.LogID,
   sum(teacher_charge_back.ChargeBackAmount) ChargeBackAmount
from
   teacher_charge_back
where
   teacher_charge_back.ChargeBackName = ''其他''
group by
   teacher_charge_back.LogID
'
GO
/****** Object:  View [dbo].[v_teacher_other_award]    Script Date: 03/25/2012 00:57:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_teacher_other_award]'))
EXEC dbo.sp_executesql @statement = N'
/*==============================================================*/
/* View: v_teacher_other_award                                  */
/*==============================================================*/
create view [v_teacher_other_award] as
select
teacher_award.LogID,
   teacher_award.AwardName,
   teacher_award.AwardAmount
from
   teacher_award
where
   teacher_award.AwardName = ''其他''
'
GO
/****** Object:  View [dbo].[v_teacher_job_wage]    Script Date: 03/25/2012 00:57:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_teacher_job_wage]'))
EXEC dbo.sp_executesql @statement = N'
/*==============================================================*/
/* View: v_teacher_job_wage                                     */
/*==============================================================*/
create view [v_teacher_job_wage] as
select
   teacher_basic_wage.LogID,
   teacher_basic_wage.WageType,
   teacher_basic_wage.WageAmount
from
   teacher_basic_wage
where
   teacher_basic_wage.WageType = ''职务工资'';
'
GO
/****** Object:  View [dbo].[v_teacher_insurance_wage]    Script Date: 03/25/2012 00:57:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_teacher_insurance_wage]'))
EXEC dbo.sp_executesql @statement = N'
/*==============================================================*/
/* View: v_teacher_insurance_wage                               */
/*==============================================================*/
create view [v_teacher_insurance_wage] as
select
   teacher_basic_wage.LogID,
   teacher_basic_wage.WageType,
   teacher_basic_wage.WageAmount
from
   teacher_basic_wage
where
   teacher_basic_wage.WageType = ''保险补贴'';
'
GO
/****** Object:  View [dbo].[v_teacher_holiday_wage]    Script Date: 03/25/2012 00:57:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_teacher_holiday_wage]'))
EXEC dbo.sp_executesql @statement = N'
/*==============================================================*/
/* View: v_teacher_holiday_wage                                 */
/*==============================================================*/
create view [v_teacher_holiday_wage] as
select
   teacher_basic_wage.LogID,
   teacher_basic_wage.WageType,
   teacher_basic_wage.WageAmount
from
   teacher_basic_wage
where
   teacher_basic_wage.WageType = ''岗位工资'';
'
GO
/****** Object:  View [dbo].[v_teacher_full_award]    Script Date: 03/25/2012 00:57:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_teacher_full_award]'))
EXEC dbo.sp_executesql @statement = N'
/*==============================================================*/
/* View: v_teacher_full_award                                   */
/*==============================================================*/
create view [v_teacher_full_award] as
select
   teacher_award.LogID,
   teacher_award.AwardName,
   teacher_award.AwardAmount
from
   teacher_award
where
   teacher_award.AwardName = ''满勤奖''
'
GO
/****** Object:  View [dbo].[v_teacher_course_wage]    Script Date: 03/25/2012 00:57:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_teacher_course_wage]'))
EXEC dbo.sp_executesql @statement = N'
/*==============================================================*/
/* View: v_teacher_course_wage                                  */
/*==============================================================*/
create view [v_teacher_course_wage] as
select teacher_course_salary.LogID, SUM(teacher_course_salary.CourseAmount) as CourseAmount
   from
   teacher_course_salary
   group by teacher_course_salary.LogID
'
GO
/****** Object:  View [dbo].[v_teacher_checkin_charge_back]    Script Date: 03/25/2012 00:57:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_teacher_checkin_charge_back]'))
EXEC dbo.sp_executesql @statement = N'
/*==============================================================*/
/* View: v_teacher_checkin_charge_back                          */
/*==============================================================*/
create view [v_teacher_checkin_charge_back] as
select
teacher_charge_back.LogID,
   sum(teacher_charge_back.ChargeBackAmount) ChargeBackAmount
from
   teacher_charge_back
where
   teacher_charge_back.ChargeBackName = ''迟到处罚''
   or teacher_charge_back.ChargeBackName = ''请假处罚''
   or teacher_charge_back.ChargeBackName = ''旷工处罚''
group by
   teacher_charge_back.LogID
'
GO
/****** Object:  View [dbo].[v_teacher_basic_wage]    Script Date: 03/25/2012 00:57:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_teacher_basic_wage]'))
EXEC dbo.sp_executesql @statement = N'
/*==============================================================*/
/* View: v_teacher_basic_wage                                   */
/*==============================================================*/
create view [v_teacher_basic_wage] as
select
   teacher_basic_wage.LogID,
   teacher_basic_wage.WageType,
   teacher_basic_wage.WageAmount
from
   teacher_basic_wage
where
   teacher_basic_wage.WageType = ''基本工资'';
'
GO
/****** Object:  View [dbo].[v_teacher_award]    Script Date: 03/25/2012 00:57:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_teacher_award]'))
EXEC dbo.sp_executesql @statement = N'
/*==============================================================*/
/* View: v_teacher_award                                        */
/*==============================================================*/
create view [v_teacher_award] as
select
   teacher_award.LogID,
   sum(teacher_award.AwardAmount) as AwardAmount
from
   teacher_award
where
   teacher_award.AwardName <> ''绩效考核奖''
   and teacher_award.AwardName <> ''满勤奖''
   and teacher_award.AwardName <> ''其他''
   group by teacher_award.LogID
'
GO
/****** Object:  View [dbo].[v_teacher_appraisal_award]    Script Date: 03/25/2012 00:57:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_teacher_appraisal_award]'))
EXEC dbo.sp_executesql @statement = N'
/*==============================================================*/
/* View: v_teacher_appraisal_award                              */
/*==============================================================*/
create view [v_teacher_appraisal_award] as
select
teacher_award.LogID,
   teacher_award.AwardName,
   teacher_award.AwardAmount
from
   teacher_award
where
   teacher_award.AwardName = ''绩效考核奖''
'
GO
/****** Object:  View [dbo].[v_teacher_age_wage]    Script Date: 03/25/2012 00:57:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_teacher_age_wage]'))
EXEC dbo.sp_executesql @statement = N'
/*==============================================================*/
/* View: v_teacher_age_wage                                     */
/*==============================================================*/
create view [v_teacher_age_wage] as
select
   teacher_basic_wage.LogID,
   teacher_basic_wage.WageType,
   teacher_basic_wage.WageAmount
from
   teacher_basic_wage
where
   teacher_basic_wage.WageType = ''工龄补贴''
'
GO
/****** Object:  View [dbo].[v_teacher_work_wage]    Script Date: 03/25/2012 00:57:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_teacher_work_wage]'))
EXEC dbo.sp_executesql @statement = N'
/*==============================================================*/
/* View: v_teacher_work_wage                                    */
/*==============================================================*/
create view [v_teacher_work_wage] as
select
   teacher_basic_wage.LogID,
   teacher_basic_wage.WageType,
   teacher_basic_wage.WageAmount
from
   teacher_basic_wage
where
   teacher_basic_wage.WageType = ''加班补贴'';
'
GO
/****** Object:  View [dbo].[v_teacher_withhold_charge_back]    Script Date: 03/25/2012 00:57:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_teacher_withhold_charge_back]'))
EXEC dbo.sp_executesql @statement = N'
/*==============================================================*/
/* View: v_teacher_withhold_charge_back                         */
/*==============================================================*/
create view [v_teacher_withhold_charge_back] as
select
teacher_charge_back.LogID,
   sum(teacher_charge_back.ChargeBackAmount) ChargeBackAmount
from
   teacher_charge_back
where
   teacher_charge_back.ChargeBackName = ''代扣''
group by
   teacher_charge_back.LogID
'
GO
/****** Object:  View [dbo].[v_teacher_wages]    Script Date: 03/25/2012 00:57:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_teacher_wages]'))
EXEC dbo.sp_executesql @statement = N'
/*==============================================================*/
/* View: v_teacher_wages                                        */
/*==============================================================*/
create view [v_teacher_wages] as
select  teacher_salary_log.LogID, 
		teacher_salary_log.TeacherID, 
		tearchers.Name as TeacherName,
		tearchers.Password as TeacherPassword,
		CONVERT(varchar(7), teacher_salary_log.CreateDate, 120) as CreateDate,
		teacher_salary_log.CreateDate as WageTime,
		v_teacher_basic_wage.WageAmount as BasicWage,	--基本工资
		v_teacher_age_wage.WageAmount as AgeWage,	--工龄工资
		v_teacher_job_wage.WageAmount as JobWage,	--职务工资
		v_teacher_insurance_wage.WageAmount as InsuranceWage,	--保险补贴
		v_teacher_holiday_wage.WageAmount as HolidayWage,	--节假日补贴
		v_teacher_work_wage.WageAmount as WorkWage,	--加班补贴
		v_teacher_course_wage.CourseAmount,	--课量工资
		v_teacher_other_wage.WageAmount as OtherWage,	--其他补贴
		v_teacher_full_award.AwardAmount as FullAward,	--满勤奖
		v_teacher_student_award.Amount as StudentAward,	--学生管理奖
		v_teacher_award.AwardAmount as Award,	--奖励
		v_teacher_appraisal_award.AwardAmount as AppraisalAward,	--绩效
		v_teacher_other_award.AwardAmount as OtherAward,	--其他
		teacher_salary_log.ShouldWages as TotalWage, --合计
		teacher_salary_log.ShouldWages,	--应发合计
		isnull(v_teacher_checkin_charge_back.ChargeBackAmount,0.00) as CheckinChargeBack,	--考勤扣款
		isnull(v_teacher_withhold_charge_back.ChargeBackAmount,0.00) as WithholdChargeBack,	--代扣
		isnull(v_teacher_other_charge_back.ChargeBackAmount,0.00) as OtherChargeBack,	
		(teacher_salary_log.RealWages-teacher_salary_log.ShouldWages) as MinusWages,
		teacher_salary_log.RealWages,
		teacher_salary_log.TeacherName as CheckName
from teacher_salary_log 
inner join tearchers on tearchers.ID = teacher_salary_log.TeacherID
inner join v_teacher_basic_wage on v_teacher_basic_wage.LogID = teacher_salary_log.LogID
inner join v_teacher_age_wage on v_teacher_age_wage.LogID = teacher_salary_log.LogID
inner join v_teacher_job_wage on v_teacher_job_wage.LogID = teacher_salary_log.LogID
inner join v_teacher_insurance_wage on v_teacher_insurance_wage.LogID = teacher_salary_log.LogID
inner join v_teacher_holiday_wage on v_teacher_holiday_wage.LogID = teacher_salary_log.LogID
inner join v_teacher_work_wage on v_teacher_work_wage.LogID = teacher_salary_log.LogID
inner join v_teacher_course_wage on v_teacher_course_wage.LogID = teacher_salary_log.LogID
inner join v_teacher_other_wage on v_teacher_other_wage.LogID = teacher_salary_log.LogID
inner join v_teacher_full_award on v_teacher_full_award.LogID = teacher_salary_log.LogID
inner join v_teacher_student_award on v_teacher_student_award.LogID = teacher_salary_log.LogID
inner join v_teacher_award on v_teacher_award.LogID = teacher_salary_log.LogID
inner join v_teacher_appraisal_award on v_teacher_appraisal_award.LogID = teacher_salary_log.LogID
inner join v_teacher_other_award on v_teacher_other_award.LogID = teacher_salary_log.LogID
left join v_teacher_checkin_charge_back on v_teacher_checkin_charge_back.LogID = teacher_salary_log.LogID
left join v_teacher_withhold_charge_back on v_teacher_withhold_charge_back.LogID = teacher_salary_log.LogID
left join v_teacher_other_charge_back on v_teacher_other_charge_back.LogID = teacher_salary_log.LogID
'
GO
/****** Object:  Table [dbo].[course_subtypes]    Script Date: 03/25/2012 00:57:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[course_subtypes]') AND type in (N'U'))
BEGIN
CREATE TABLE [course_subtypes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CourseTypeID] [int] NOT NULL,
	[CourseSubtypeName] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_course_subtypes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  StoredProcedure [dbo].[InsertQuery]    Script Date: 03/25/2012 00:57:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[InsertQuery]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

CREATE PROCEDURE [InsertQuery]
(
	@TeacherID int,
	@ShouldWages money,
	@RealWages money,
	@CreateDate datetime,
	@Operator varchar(50)
)
AS
	SET NOCOUNT OFF;
INSERT INTO teacher_salary_log (TeacherID, ShouldWages, RealWages, CreateDate, Operator) VALUES (@TeacherID, @ShouldWages, @RealWages, @CreateDate, @Operator);
	 
SELECT LogID FROM teacher_salary_log WHERE (LogID = SCOPE_IDENTITY())
' 
END
GO
/****** Object:  Table [dbo].[students]    Script Date: 03/25/2012 00:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[students]') AND type in (N'U'))
BEGIN
CREATE TABLE [students](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NULL,
	[Sex] [nchar](1) NULL,
	[Telephone] [nvarchar](20) NULL,
	[Address] [nvarchar](50) NULL,
	[Birthday] [date] NULL,
	[FartherName] [nvarchar](20) NULL,
	[FartherWork] [nvarchar](50) NULL,
	[FartherTel] [nvarchar](20) NULL,
	[MotherName] [nvarchar](20) NULL,
	[MotherWork] [nvarchar](50) NULL,
	[MotherTel] [nvarchar](20) NULL,
	[Status] [int] NOT NULL CONSTRAINT [DF_students_Status]  DEFAULT ((0)),
	[Balance] [int] NOT NULL CONSTRAINT [DF_students_Balance]  DEFAULT ((0)),
	[PreregisterCourseSubtype] [int] NULL,
	[CardNo] [nvarchar](50) NULL,
	[ExpireTime] [datetime] NULL,
	[CardType] [int] NOT NULL CONSTRAINT [DF_students_CardInfo]  DEFAULT ((0)),
	[Recommender] [nvarchar](50) NULL,
 CONSTRAINT [PK_students] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'students', N'COLUMN',N'Status'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0: 预报名
1: 正式生
2: 欠费' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'students', @level2type=N'COLUMN',@level2name=N'Status'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'students', N'COLUMN',N'CardType'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0: 普通卡; 1:VIP卡' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'students', @level2type=N'COLUMN',@level2name=N'CardType'
GO
/****** Object:  View [dbo].[v_cards]    Script Date: 03/25/2012 00:57:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_cards]'))
EXEC dbo.sp_executesql @statement = N'
/*==============================================================*/
/* View: v_cards                                                */
/*==============================================================*/
create view [v_cards] as
select ID,Name,CardNo,1 AS CardType from students where CardNo <> ''''
union 
select ID,Name,CardNo,2 AS CardType from tearchers where CardNo <> ''''
'
GO
/****** Object:  Table [dbo].[courses]    Script Date: 03/25/2012 00:57:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[courses]') AND type in (N'U'))
BEGIN
CREATE TABLE [courses](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CourseSubTypeID] [int] NOT NULL,
	[CourseName] [nvarchar](50) NOT NULL,
	[ChargeType] [int] NOT NULL CONSTRAINT [DF_courses_CourseChargeType]  DEFAULT ((0)),
	[ChargeAmount] [int] NOT NULL CONSTRAINT [DF_courses_ChargeAmount]  DEFAULT ((0)),
	[TeacherID] [int] NULL,
 CONSTRAINT [PK_courses_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'courses', N'COLUMN',N'ChargeType'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0: 按季度收费
1: 按月份收费
2: 按课次收费' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'courses', @level2type=N'COLUMN',@level2name=N'ChargeType'
GO
/****** Object:  Table [dbo].[course_time]    Script Date: 03/25/2012 00:57:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[course_time]') AND type in (N'U'))
BEGIN
CREATE TABLE [course_time](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CourseID] [int] NOT NULL,
	[ClassroomID] [int] NOT NULL,
	[DayOfWeek] [int] NOT NULL,
	[BeginTime] [datetime] NOT NULL CONSTRAINT [DF_course_time_BeginTime]  DEFAULT ('1900/1/1 0:0:0'),
	[EndTime] [datetime] NOT NULL CONSTRAINT [DF_course_time_EndTime]  DEFAULT ('1900/1/1 0:0:0'),
 CONSTRAINT [PK_course_time] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[deposit_list]    Script Date: 03/25/2012 00:57:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[deposit_list]') AND type in (N'U'))
BEGIN
CREATE TABLE [deposit_list](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [int] NOT NULL,
	[DepositAmount] [int] NOT NULL,
	[ActualPaidAmount] [int] NOT NULL,
	[DepositDate] [datetime] NOT NULL,
	[Operator] [varchar](50) NULL,
 CONSTRAINT [PK_deposit_list] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[student_cost]    Script Date: 03/25/2012 00:57:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[student_cost]') AND type in (N'U'))
BEGIN
CREATE TABLE [student_cost](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [int] NOT NULL,
	[CourseID] [int] NOT NULL,
	[CostAmount] [int] NOT NULL,
	[CostDate] [datetime] NOT NULL,
	[DiscountLevel] [int] NOT NULL CONSTRAINT [DF_student_cost_Discount]  DEFAULT ((100)),
	[ActualCostAmount] [int] NOT NULL,
	[DiscountReason] [nvarchar](200) NULL,
	[Operator] [varchar](50) NULL,
	[CourseTimeID] [int] NULL,
	[OldExpireTime] [datetime] NULL,
 CONSTRAINT [PK_student_cost] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[v_users_course]    Script Date: 03/25/2012 00:57:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_users_course]'))
EXEC dbo.sp_executesql @statement = N'create view [v_users_course] as
SELECT     ucp.Id AS UserID, ucp.UserName, ucp.CourseId, ISNULL(c.CourseSubTypeID, 0) AS CourseSubTypeID, ISNULL(cs.CourseTypeID, 0) AS CourseTypeID
FROM         dbo.users_course_privilege AS ucp LEFT OUTER JOIN
                      dbo.courses AS c ON ucp.CourseId = c.ID LEFT OUTER JOIN
                      dbo.course_subtypes AS cs ON cs.ID = c.CourseSubTypeID
'
GO
/****** Object:  Table [dbo].[student_signin]    Script Date: 03/25/2012 00:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[student_signin]') AND type in (N'U'))
BEGIN
CREATE TABLE [student_signin](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [int] NOT NULL,
	[SigninTime] [datetime] NOT NULL,
 CONSTRAINT [PK_student_signin] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[student_courses_cost]    Script Date: 03/25/2012 00:57:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[student_courses_cost]') AND type in (N'U'))
BEGIN
CREATE TABLE [student_courses_cost](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [int] NOT NULL,
	[CourseID] [int] NOT NULL,
	[CourseTimeID] [int] NULL,
	[CostAmount] [int] NOT NULL,
	[CostDate] [datetime] NOT NULL,
	[DiscountLevel] [int] NOT NULL CONSTRAINT [DF_student_courses_cost_Discount]  DEFAULT ((100)),
	[ActualCostAmount] [int] NOT NULL,
	[DiscountReason] [nvarchar](200) NULL,
	[Operator] [varchar](50) NULL,
 CONSTRAINT [PK_student_courses_cost] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[student_courses]    Script Date: 03/25/2012 00:57:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[student_courses]') AND type in (N'U'))
BEGIN
CREATE TABLE [student_courses](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [int] NOT NULL,
	[CourseID] [int] NOT NULL,
	[ExpireTime] [datetime] NOT NULL,
	[Balance] [int] NULL CONSTRAINT [DF_student_courses_Balance]  DEFAULT ((0)),
	[CourseNum] [int] NULL CONSTRAINT [DF_student_courses_CourseNum]  DEFAULT ((0)),
 CONSTRAINT [PK_student_courses] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  View [dbo].[v_student_courses]    Script Date: 03/25/2012 00:57:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_student_courses]'))
EXEC dbo.sp_executesql @statement = N'create view [v_student_courses] as
SELECT     ID, StudentID, CourseID, ExpireTime, Balance, CourseNum
FROM         dbo.student_courses
WHERE     (ID =
                          (SELECT     MAX(ID) AS Expr1
                            FROM          dbo.student_courses AS sc
                            WHERE      (StudentID = dbo.student_courses.StudentID) AND (dbo.student_courses.CourseID = CourseID)))
'
GO
/****** Object:  View [dbo].[v_course]    Script Date: 03/25/2012 00:57:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[v_course]'))
EXEC dbo.sp_executesql @statement = N'create view [v_course] as
SELECT     ID, CourseName,
                          (SELECT     CourseTypeID
                            FROM          dbo.course_subtypes AS cst
                            WHERE      (ID = c.CourseSubTypeID)) AS CourseTypeID, CourseSubTypeID, ChargeType, ChargeAmount, TeacherID, ISNULL
                          ((SELECT     COUNT(0) AS StudentCount
                              FROM         dbo.student_cost AS sc
                              WHERE     (CourseID = c.ID)), 0) AS StudentCount
FROM         dbo.courses AS c
'
GO
/****** Object:  ForeignKey [FK_course_subtypes_course_types]    Script Date: 03/25/2012 00:57:36 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_course_subtypes_course_types]') AND parent_object_id = OBJECT_ID(N'[course_subtypes]'))
ALTER TABLE [course_subtypes]  WITH CHECK ADD  CONSTRAINT [FK_course_subtypes_course_types] FOREIGN KEY([CourseTypeID])
REFERENCES [course_types] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_course_subtypes_course_types]') AND parent_object_id = OBJECT_ID(N'[course_subtypes]'))
ALTER TABLE [course_subtypes] CHECK CONSTRAINT [FK_course_subtypes_course_types]
GO
/****** Object:  ForeignKey [FK_course_time_classrooms]    Script Date: 03/25/2012 00:57:36 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_course_time_classrooms]') AND parent_object_id = OBJECT_ID(N'[course_time]'))
ALTER TABLE [course_time]  WITH CHECK ADD  CONSTRAINT [FK_course_time_classrooms] FOREIGN KEY([ClassroomID])
REFERENCES [classrooms] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_course_time_classrooms]') AND parent_object_id = OBJECT_ID(N'[course_time]'))
ALTER TABLE [course_time] CHECK CONSTRAINT [FK_course_time_classrooms]
GO
/****** Object:  ForeignKey [FK_course_time_courses]    Script Date: 03/25/2012 00:57:36 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_course_time_courses]') AND parent_object_id = OBJECT_ID(N'[course_time]'))
ALTER TABLE [course_time]  WITH CHECK ADD  CONSTRAINT [FK_course_time_courses] FOREIGN KEY([CourseID])
REFERENCES [courses] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_course_time_courses]') AND parent_object_id = OBJECT_ID(N'[course_time]'))
ALTER TABLE [course_time] CHECK CONSTRAINT [FK_course_time_courses]
GO
/****** Object:  ForeignKey [FK_course_time_day_of_week]    Script Date: 03/25/2012 00:57:36 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_course_time_day_of_week]') AND parent_object_id = OBJECT_ID(N'[course_time]'))
ALTER TABLE [course_time]  WITH CHECK ADD  CONSTRAINT [FK_course_time_day_of_week] FOREIGN KEY([DayOfWeek])
REFERENCES [day_of_week] ([DayOfWeekValue])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_course_time_day_of_week]') AND parent_object_id = OBJECT_ID(N'[course_time]'))
ALTER TABLE [course_time] CHECK CONSTRAINT [FK_course_time_day_of_week]
GO
/****** Object:  ForeignKey [FK_courses_charge_type]    Script Date: 03/25/2012 00:57:36 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_courses_charge_type]') AND parent_object_id = OBJECT_ID(N'[courses]'))
ALTER TABLE [courses]  WITH CHECK ADD  CONSTRAINT [FK_courses_charge_type] FOREIGN KEY([ChargeType])
REFERENCES [charge_type] ([ChargeTypeID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_courses_charge_type]') AND parent_object_id = OBJECT_ID(N'[courses]'))
ALTER TABLE [courses] CHECK CONSTRAINT [FK_courses_charge_type]
GO
/****** Object:  ForeignKey [FK_courses_course_subtypes]    Script Date: 03/25/2012 00:57:36 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_courses_course_subtypes]') AND parent_object_id = OBJECT_ID(N'[courses]'))
ALTER TABLE [courses]  WITH CHECK ADD  CONSTRAINT [FK_courses_course_subtypes] FOREIGN KEY([CourseSubTypeID])
REFERENCES [course_subtypes] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_courses_course_subtypes]') AND parent_object_id = OBJECT_ID(N'[courses]'))
ALTER TABLE [courses] CHECK CONSTRAINT [FK_courses_course_subtypes]
GO
/****** Object:  ForeignKey [FK_deposit_list_students]    Script Date: 03/25/2012 00:57:36 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_deposit_list_students]') AND parent_object_id = OBJECT_ID(N'[deposit_list]'))
ALTER TABLE [deposit_list]  WITH CHECK ADD  CONSTRAINT [FK_deposit_list_students] FOREIGN KEY([StudentID])
REFERENCES [students] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_deposit_list_students]') AND parent_object_id = OBJECT_ID(N'[deposit_list]'))
ALTER TABLE [deposit_list] CHECK CONSTRAINT [FK_deposit_list_students]
GO
/****** Object:  ForeignKey [FK_student_cost_courses]    Script Date: 03/25/2012 00:57:37 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_student_cost_courses]') AND parent_object_id = OBJECT_ID(N'[student_cost]'))
ALTER TABLE [student_cost]  WITH CHECK ADD  CONSTRAINT [FK_student_cost_courses] FOREIGN KEY([CourseID])
REFERENCES [courses] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_student_cost_courses]') AND parent_object_id = OBJECT_ID(N'[student_cost]'))
ALTER TABLE [student_cost] CHECK CONSTRAINT [FK_student_cost_courses]
GO
/****** Object:  ForeignKey [FK_student_cost_discount_level]    Script Date: 03/25/2012 00:57:37 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_student_cost_discount_level]') AND parent_object_id = OBJECT_ID(N'[student_cost]'))
ALTER TABLE [student_cost]  WITH CHECK ADD  CONSTRAINT [FK_student_cost_discount_level] FOREIGN KEY([DiscountLevel])
REFERENCES [discount_level] ([DiscountLevel])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_student_cost_discount_level]') AND parent_object_id = OBJECT_ID(N'[student_cost]'))
ALTER TABLE [student_cost] CHECK CONSTRAINT [FK_student_cost_discount_level]
GO
/****** Object:  ForeignKey [FK_student_cost_students]    Script Date: 03/25/2012 00:57:37 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_student_cost_students]') AND parent_object_id = OBJECT_ID(N'[student_cost]'))
ALTER TABLE [student_cost]  WITH CHECK ADD  CONSTRAINT [FK_student_cost_students] FOREIGN KEY([StudentID])
REFERENCES [students] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_student_cost_students]') AND parent_object_id = OBJECT_ID(N'[student_cost]'))
ALTER TABLE [student_cost] CHECK CONSTRAINT [FK_student_cost_students]
GO
/****** Object:  ForeignKey [FK_student_courses_courses]    Script Date: 03/25/2012 00:57:37 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_student_courses_courses]') AND parent_object_id = OBJECT_ID(N'[student_courses]'))
ALTER TABLE [student_courses]  WITH CHECK ADD  CONSTRAINT [FK_student_courses_courses] FOREIGN KEY([CourseID])
REFERENCES [courses] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_student_courses_courses]') AND parent_object_id = OBJECT_ID(N'[student_courses]'))
ALTER TABLE [student_courses] CHECK CONSTRAINT [FK_student_courses_courses]
GO
/****** Object:  ForeignKey [FK_student_courses_students]    Script Date: 03/25/2012 00:57:37 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_student_courses_students]') AND parent_object_id = OBJECT_ID(N'[student_courses]'))
ALTER TABLE [student_courses]  WITH CHECK ADD  CONSTRAINT [FK_student_courses_students] FOREIGN KEY([StudentID])
REFERENCES [students] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_student_courses_students]') AND parent_object_id = OBJECT_ID(N'[student_courses]'))
ALTER TABLE [student_courses] CHECK CONSTRAINT [FK_student_courses_students]
GO
/****** Object:  ForeignKey [FK_student_courses_cost_courses]    Script Date: 03/25/2012 00:57:37 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_student_courses_cost_courses]') AND parent_object_id = OBJECT_ID(N'[student_courses_cost]'))
ALTER TABLE [student_courses_cost]  WITH CHECK ADD  CONSTRAINT [FK_student_courses_cost_courses] FOREIGN KEY([CourseID])
REFERENCES [courses] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_student_courses_cost_courses]') AND parent_object_id = OBJECT_ID(N'[student_courses_cost]'))
ALTER TABLE [student_courses_cost] CHECK CONSTRAINT [FK_student_courses_cost_courses]
GO
/****** Object:  ForeignKey [FK_student_courses_cost_discount_level]    Script Date: 03/25/2012 00:57:37 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_student_courses_cost_discount_level]') AND parent_object_id = OBJECT_ID(N'[student_courses_cost]'))
ALTER TABLE [student_courses_cost]  WITH CHECK ADD  CONSTRAINT [FK_student_courses_cost_discount_level] FOREIGN KEY([DiscountLevel])
REFERENCES [discount_level] ([DiscountLevel])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_student_courses_cost_discount_level]') AND parent_object_id = OBJECT_ID(N'[student_courses_cost]'))
ALTER TABLE [student_courses_cost] CHECK CONSTRAINT [FK_student_courses_cost_discount_level]
GO
/****** Object:  ForeignKey [FK_student_courses_cost_students]    Script Date: 03/25/2012 00:57:37 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_student_courses_cost_students]') AND parent_object_id = OBJECT_ID(N'[student_courses_cost]'))
ALTER TABLE [student_courses_cost]  WITH CHECK ADD  CONSTRAINT [FK_student_courses_cost_students] FOREIGN KEY([StudentID])
REFERENCES [students] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_student_courses_cost_students]') AND parent_object_id = OBJECT_ID(N'[student_courses_cost]'))
ALTER TABLE [student_courses_cost] CHECK CONSTRAINT [FK_student_courses_cost_students]
GO
/****** Object:  ForeignKey [FK_student_signin_students]    Script Date: 03/25/2012 00:57:38 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_student_signin_students]') AND parent_object_id = OBJECT_ID(N'[student_signin]'))
ALTER TABLE [student_signin]  WITH CHECK ADD  CONSTRAINT [FK_student_signin_students] FOREIGN KEY([StudentID])
REFERENCES [students] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_student_signin_students]') AND parent_object_id = OBJECT_ID(N'[student_signin]'))
ALTER TABLE [student_signin] CHECK CONSTRAINT [FK_student_signin_students]
GO
/****** Object:  ForeignKey [FK_students_card_type]    Script Date: 03/25/2012 00:57:38 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_students_card_type]') AND parent_object_id = OBJECT_ID(N'[students]'))
ALTER TABLE [students]  WITH CHECK ADD  CONSTRAINT [FK_students_card_type] FOREIGN KEY([CardType])
REFERENCES [card_type] ([CardTypeID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_students_card_type]') AND parent_object_id = OBJECT_ID(N'[students]'))
ALTER TABLE [students] CHECK CONSTRAINT [FK_students_card_type]
GO
/****** Object:  ForeignKey [FK_students_course_subtypes]    Script Date: 03/25/2012 00:57:38 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_students_course_subtypes]') AND parent_object_id = OBJECT_ID(N'[students]'))
ALTER TABLE [students]  WITH CHECK ADD  CONSTRAINT [FK_students_course_subtypes] FOREIGN KEY([PreregisterCourseSubtype])
REFERENCES [course_subtypes] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_students_course_subtypes]') AND parent_object_id = OBJECT_ID(N'[students]'))
ALTER TABLE [students] CHECK CONSTRAINT [FK_students_course_subtypes]
GO
/****** Object:  ForeignKey [FK_students_student_status]    Script Date: 03/25/2012 00:57:38 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_students_student_status]') AND parent_object_id = OBJECT_ID(N'[students]'))
ALTER TABLE [students]  WITH CHECK ADD  CONSTRAINT [FK_students_student_status] FOREIGN KEY([Status])
REFERENCES [student_status] ([StatusID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_students_student_status]') AND parent_object_id = OBJECT_ID(N'[students]'))
ALTER TABLE [students] CHECK CONSTRAINT [FK_students_student_status]
GO

/****** Object:  Table [dbo].[users]    Script Date: 03/25/2012 01:13:33 ******/
INSERT [users] ([UserName], [Password], [UserType]) VALUES (N'董事长', N'88866', 3)
INSERT [users] ([UserName], [Password], [UserType]) VALUES (N'test', N'123', 3)
INSERT [users] ([UserName], [Password], [UserType]) VALUES (N'高世峰', N'1', 2)
INSERT [users] ([UserName], [Password], [UserType]) VALUES (N'郑文静', N'77999', 1)
/****** Object:  Table [dbo].[student_status]    Script Date: 03/25/2012 01:13:33 ******/
INSERT [student_status] ([StatusID], [StatusName]) VALUES (0, N'预报名')
INSERT [student_status] ([StatusID], [StatusName]) VALUES (1, N'正常')
INSERT [student_status] ([StatusID], [StatusName]) VALUES (2, N'请假')
INSERT [student_status] ([StatusID], [StatusName]) VALUES (3, N'欠费')
INSERT [student_status] ([StatusID], [StatusName]) VALUES (4, N'离班')
/****** Object:  Table [dbo].[software_version]    Script Date: 03/25/2012 01:13:33 ******/
INSERT [software_version] ([SoftwareName], [SoftwareVersion], [Remark]) VALUES (N'ShaoNianGong', N'1.0.8', N'“海鹰教育”福鼎市青少年宫培训服务中心管理系统')
INSERT [software_version] ([SoftwareName], [SoftwareVersion], [Remark]) VALUES (N'BanGongPingTai', N'1.0.5', N'“海鹰教育”福鼎市青少年宫培训服务中心办公管理系统')
INSERT [software_version] ([SoftwareName], [SoftwareVersion], [Remark]) VALUES (N'XueShengQianDao', N'1.0.8', N'“海鹰教育”福鼎市青少年宫培训服务中心签到平台')
/****** Object:  Table [dbo].[discount_level]    Script Date: 03/25/2012 01:13:33 ******/
INSERT [discount_level] ([DiscountLevel], [DiscountLevelName]) VALUES (75, N'75折')
INSERT [discount_level] ([DiscountLevel], [DiscountLevelName]) VALUES (80, N'8折')
INSERT [discount_level] ([DiscountLevel], [DiscountLevelName]) VALUES (85, N'85折')
INSERT [discount_level] ([DiscountLevel], [DiscountLevelName]) VALUES (90, N'9折')
INSERT [discount_level] ([DiscountLevel], [DiscountLevelName]) VALUES (95, N'95折')
INSERT [discount_level] ([DiscountLevel], [DiscountLevelName]) VALUES (100, N'标准')
/****** Object:  Table [dbo].[day_of_week]    Script Date: 03/25/2012 01:13:33 ******/
INSERT [day_of_week] ([DayOfWeekValue], [DayOfWeekName]) VALUES (1, N'星期一')
INSERT [day_of_week] ([DayOfWeekValue], [DayOfWeekName]) VALUES (2, N'星期二')
INSERT [day_of_week] ([DayOfWeekValue], [DayOfWeekName]) VALUES (3, N'星期三')
INSERT [day_of_week] ([DayOfWeekValue], [DayOfWeekName]) VALUES (4, N'星期四')
INSERT [day_of_week] ([DayOfWeekValue], [DayOfWeekName]) VALUES (5, N'星期五')
INSERT [day_of_week] ([DayOfWeekValue], [DayOfWeekName]) VALUES (6, N'星期六')
INSERT [day_of_week] ([DayOfWeekValue], [DayOfWeekName]) VALUES (7, N'星期日')
/****** Object:  Table [dbo].[charge_type]    Script Date: 03/25/2012 01:13:33 ******/
INSERT [charge_type] ([ChargeTypeID], [ChargeTypeName]) VALUES (0, N'按季度收费')
INSERT [charge_type] ([ChargeTypeID], [ChargeTypeName]) VALUES (1, N'按月份收费')
INSERT [charge_type] ([ChargeTypeID], [ChargeTypeName]) VALUES (2, N'按课次收费')
/****** Object:  Table [dbo].[card_type]    Script Date: 03/25/2012 01:13:33 ******/
INSERT [card_type] ([CardTypeID], [CardTypeName]) VALUES (0, N'普通卡')
INSERT [card_type] ([CardTypeID], [CardTypeName]) VALUES (1, N'VIP卡')