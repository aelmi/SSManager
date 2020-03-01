using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SSManager
{
    public class MssqlOperation
    {

        public MssqlOperation(SqlConnection con)
        {
            DBHelper.con = con;
        }

        public string DatabaseName;      

        public void ChangeDB(string DBName)
        {
            DBHelper.DatabaseName = DBName;
            DBHelper.ChangeConnectionString();
            DatabaseName = DBName;
        }

        #region SystemCatalog Methods
        public DataTable getDatabases()
        {
            return DBHelper.ExecuteDT("SELECT name,database_id FROM sys.databases ORDER BY Name");
        }

        public DataTable getTables()
        {
            return DBHelper.ExecuteDT("SELECT TABLE_NAME, TABLE_SCHEMA FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'");
        }

        public DataTable getViews()
        {
            return DBHelper.ExecuteDT("SELECT TABLE_NAME, TABLE_SCHEMA FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'VIEW'");
        }

        public DataTable getSPs()
        {
            return DBHelper.ExecuteDT("SELECT name FROM sys.procedures");
        }

        public DataTable getFunctions()
        {
            return DBHelper.ExecuteDT("SELECT name, [type] FROM sys.objects WHERE type = 'TF' OR type='FN' ORDER BY [type] DESC");
        }

        public DataTable getTriggers()
        {
            return DBHelper.ExecuteDT("SELECT name FROM sys.triggers");
        }
        #endregion

        #region Shrink Methods
        public void ShrinkDatabase()
        {
            string DatabaseName = DBHelper.DatabaseName;
            DBHelper.ExecuteNonQuery("DBCC SHRINKDATABASE(N'" + DatabaseName + "' )");
        }

        public void ShrinkFiles()
        {
            string DatabaseName = DBHelper.DatabaseName;
            DBHelper.ExecuteNonQuery("DBCC SHRINKFILE (N'" + DatabaseName + "' , 0, TRUNCATEONLY)");
        }
        #endregion

        #region Index Methods

        public DataTable ShowMissingIndex()
        {
            return DBHelper.ExecuteDT(@"
                                    SELECT --TOP 25
                                      dm_mid.database_id AS DatabaseID,
                                      dm_migs.avg_user_impact*(dm_migs.user_seeks+dm_migs.user_scans) Avg_Estimated_Impact,
                                      dm_migs.last_user_seek AS Last_User_Seek,
                                      OBJECT_NAME(dm_mid.OBJECT_ID,dm_mid.database_id) AS [TableName],
                                      'CREATE INDEX [IX_' + OBJECT_NAME(dm_mid.OBJECT_ID,dm_mid.database_id) + '_'
                                      + REPLACE(REPLACE(REPLACE(ISNULL(dm_mid.equality_columns,''),', ','_'),'[',''),']','') +
                                      CASE
                                        WHEN dm_mid.equality_columns IS NOT NULL AND dm_mid.inequality_columns IS NOT NULL THEN '_'
                                        ELSE ''
                                      END
                                      + REPLACE(REPLACE(REPLACE(ISNULL(dm_mid.inequality_columns,''),', ','_'),'[',''),']','')
                                      + ']' + ' ON ' + dm_mid.statement + ' (' + ISNULL (dm_mid.equality_columns,'')
                                      +
                                      CASE 
                                        WHEN dm_mid.equality_columns IS NOT NULL AND dm_mid.inequality_columns IS NOT NULL THEN ','
                                        ELSE '' 
                                      END
                                      + ISNULL (dm_mid.inequality_columns, '') + ')' + ISNULL (' INCLUDE (' + dm_mid.included_columns + ')', '') AS CreateStatement,
                                      'DROP INDEX [IX_' + OBJECT_NAME(dm_mid.OBJECT_ID,dm_mid.database_id) + '_' +
                                      + REPLACE(REPLACE(REPLACE(ISNULL(dm_mid.equality_columns,''),', ','_'),'[',''),']','') +
                                      CASE
                                        WHEN dm_mid.equality_columns IS NOT NULL AND dm_mid.inequality_columns IS NOT NULL THEN '_'
                                        ELSE ''
                                      END
                                      + REPLACE(REPLACE(REPLACE(ISNULL(dm_mid.inequality_columns,''),', ','_'),'[',''),']','')
                                      + ']' + ' ON ' + dm_mid.statement DropStatement
   
  
                                    FROM sys.dm_db_missing_index_groups dm_mig
                                      INNER JOIN sys.dm_db_missing_index_group_stats dm_migs ON dm_migs.group_handle = dm_mig.index_group_handle
                                      INNER JOIN sys.dm_db_missing_index_details dm_mid ON dm_mig.index_handle = dm_mid.index_handle
                                    WHERE dm_mid.database_ID = DB_ID()
                                    ORDER BY Avg_Estimated_Impact DESC
                                  ");
        }

        public DataTable ShowDuplicateIndex()
        {
            return DBHelper.ExecuteDT(@"
            	;WITH MyDuplicate AS (
				SELECT
					Sch.[name] AS SchemaName,
					Obj.[name] AS TableName,
					Idx.[name] AS IndexName,
					INDEX_COL(Sch.[name] + '.' + Obj.[name], Idx.index_id, 1) AS Col1,
					INDEX_COL(Sch.[name] + '.' + Obj.[name], Idx.index_id, 2) AS Col2,
					INDEX_COL(Sch.[name] + '.' + Obj.[name], Idx.index_id, 3) AS Col3,
					INDEX_COL(Sch.[name] + '.' + Obj.[name], Idx.index_id, 4) AS Col4,
					INDEX_COL(Sch.[name] + '.' + Obj.[name], Idx.index_id, 5) AS Col5,
					INDEX_COL(Sch.[name] + '.' + Obj.[name], Idx.index_id, 6) AS Col6,
					INDEX_COL(Sch.[name] + '.' + Obj.[name], Idx.index_id, 7) AS Col7,
					INDEX_COL(Sch.[name] + '.' + Obj.[name], Idx.index_id, 8) AS Col8,
					INDEX_COL(Sch.[name] + '.' + Obj.[name], Idx.index_id, 9) AS Col9,
					INDEX_COL(Sch.[name] + '.' + Obj.[name], Idx.index_id, 10) AS Col10,
					INDEX_COL(Sch.[name] + '.' + Obj.[name], Idx.index_id, 11) AS Col11,
					INDEX_COL(Sch.[name] + '.' + Obj.[name], Idx.index_id, 12) AS Col12,
					INDEX_COL(Sch.[name] + '.' + Obj.[name], Idx.index_id, 13) AS Col13,
					INDEX_COL(Sch.[name] + '.' + Obj.[name], Idx.index_id, 14) AS Col14,
					INDEX_COL(Sch.[name] + '.' + Obj.[name], Idx.index_id, 15) AS Col15,
					INDEX_COL(Sch.[name] + '.' + Obj.[name], Idx.index_id, 16) AS Col16
				FROM sys.indexes Idx
					INNER JOIN sys.objects Obj ON Idx.[object_id] = Obj.[object_id]
					INNER JOIN sys.schemas Sch ON Sch.[schema_id] = Obj.[schema_id]
					WHERE index_id > 0)
			SELECT    MD1.SchemaName, MD1.TableName, MD1.IndexName,
			MD2.IndexName AS OverLappingIndex,
			MD1.Col1, MD1.Col2, MD1.Col3, MD1.Col4,
			MD1.Col5, MD1.Col6, MD1.Col7, MD1.Col8,
			MD1.Col9, MD1.Col10, MD1.Col11, MD1.Col12,
			MD1.Col13, MD1.Col14, MD1.Col15, MD1.Col16
			FROM MyDuplicate MD1
				INNER JOIN MyDuplicate MD2 ON MD1.tablename = MD2.tablename
				AND MD1.indexname <> MD2.indexname
				AND MD1.Col1 = MD2.Col1
				AND (MD1.Col2 IS NULL OR MD2.Col2 IS NULL OR MD1.Col2 = MD2.Col2)
				AND (MD1.Col3 IS NULL OR MD2.Col3 IS NULL OR MD1.Col3 = MD2.Col3)
				AND (MD1.Col4 IS NULL OR MD2.Col4 IS NULL OR MD1.Col4 = MD2.Col4)
				AND (MD1.Col5 IS NULL OR MD2.Col5 IS NULL OR MD1.Col5 = MD2.Col5)
				AND (MD1.Col6 IS NULL OR MD2.Col6 IS NULL OR MD1.Col6 = MD2.Col6)
				AND (MD1.Col7 IS NULL OR MD2.Col7 IS NULL OR MD1.Col7 = MD2.Col7)
				AND (MD1.Col8 IS NULL OR MD2.Col8 IS NULL OR MD1.Col8 = MD2.Col8)
					AND (MD1.Col9 IS NULL OR MD2.Col9 IS NULL OR MD1.Col9 = MD2.Col9)
				AND (MD1.Col10 IS NULL OR MD2.Col10 IS NULL OR MD1.Col10 = MD2.Col10)
				AND (MD1.Col11 IS NULL OR MD2.Col11 IS NULL OR MD1.Col11 = MD2.Col11)
				AND (MD1.Col12 IS NULL OR MD2.Col12 IS NULL OR MD1.Col12 = MD2.Col12)
				AND (MD1.Col13 IS NULL OR MD2.Col13 IS NULL OR MD1.Col13 = MD2.Col13)
				AND (MD1.Col14 IS NULL OR MD2.Col14 IS NULL OR MD1.Col14 = MD2.Col14)
				AND (MD1.Col15 IS NULL OR MD2.Col15 IS NULL OR MD1.Col15 = MD2.Col15)
				AND (MD1.Col16 IS NULL OR MD2.Col16 IS NULL OR MD1.Col16 = MD2.Col16)
			ORDER BY MD1.SchemaName,MD1.TableName,MD1.IndexName
            ");

        }        

        #endregion

        public void NoCheckConstraint()
        {
            DBHelper.ExecuteNonQuery("EXEC sp_msforeachtable \"ALTER TABLE ? NOCHECK CONSTRAINT ALL\"");
        }

        public void CheckConstraint()
        {
            DBHelper.ExecuteNonQuery("EXEC sp_msforeachtable \"ALTER TABLE ? CHECK CONSTRAINT ALL\"");
        }

        public void DeleteTable(string TableName)
        {
            Int64 recCountTable = getRecordCountOfTable(TableName);
            if (recCountTable < 500000)
                DBHelper.ExecuteNonQuery("DELETE FROM " + TableName);
            else
            {
                while (recCountTable > 0)
                {
                    DBHelper.ExecuteNonQuery("DELETE TOP(10000) FROM [" + TableName + "]");
                    recCountTable = getRecordCountOfTable(TableName);
                }
            }
        }

        public Int64 getRecordCountOfTable(string TableName)
        {
            try
            {
                DataTable dtTableInfo = DBHelper.ExecuteDT("EXEC sp_spaceused " + TableName);
                return (Convert.ToInt64(dtTableInfo.Rows[0]["rows"].ToString()));
            }
            catch
            {
                return 0;
            }
        }        

        public void ReseedTable(string TableName)
        {
            DBHelper.ExecuteNonQuery("DBCC CHECKIDENT (" + TableName + ", RESEED, 0)");
        }

        public void ForceRenameDB(string OldName, string NewName)
        {
            DBHelper.ExecuteNonQuery("ALTER DATABASE " + OldName + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE ");
            DBHelper.ExecuteNonQuery("ALTER DATABASE " + OldName + " MODIFY NAME = " + NewName);
            DBHelper.ExecuteNonQuery("ALTER DATABASE " + NewName + " SET MULTI_USER");
        }

        public DataTable TableSizeInfo(string TableName)
        {
            return DBHelper.ExecuteDT("EXEC sp_spaceused '" + TableName + "'");
        }

        public DataTable AllTableSizeInfo()
        {
            return DBHelper.ExecuteDT(@"SELECT t.NAME AS TableName, s.Name AS SchemaName, p.rows AS RowCounts, 
                                    SUM(a.total_pages) * 8 AS TotalSpaceKB, SUM(a.used_pages) * 8 AS UsedSpaceKB, 
                        		    (SUM(a.total_pages) - SUM(a.used_pages)) * 8 AS UnusedSpaceKB
                              	   FROM sys.tables t INNER JOIN  sys.indexes i ON t.OBJECT_ID = i.object_id
                                                 	 INNER JOIN sys.partitions p ON i.object_id = p.OBJECT_ID AND i.index_id = p.index_id
                                                	 INNER JOIN sys.allocation_units a ON p.partition_id = a.container_id
                                                 	 LEFT OUTER JOIN sys.schemas s ON t.schema_id = s.schema_id
                                   WHERE t.NAME NOT LIKE 'dt%' AND t.is_ms_shipped = 0 AND i.OBJECT_ID > 255 
                                   GROUP BY t.Name, s.Name, p.Rows");

        }

        public void EnableCLR()
        {
            DBHelper.ExecuteNonQuery("EXEC sp_configure 'show advanced options', '1'");
            DBHelper.ExecuteNonQuery("RECONFIGURE");
            DBHelper.ExecuteNonQuery("EXEC sp_configure 'clr enabled' , '1'");
            DBHelper.ExecuteNonQuery("RECONFIGURE");
        }

        public DataTable ShowPartitionInfo()
        {
            return DBHelper.ExecuteDT(
                @"
				select pf.name as [partition_function],
					   ps.name as [partition_scheme],
					   1 as [partition_number],
					   case when prv.value is null then NULL else '<' end as [relation],
					   prv.value as [boundary_value],
					   type_name(pp.system_type_id) as [type],
					   fg.name as [filegroup],
					   case when ps.name is null then NULL else N'IN USE' end as [status]
				  from sys.partition_functions pf
				  join sys.partition_parameters pp on pp.function_id = pf.function_id
				  left join sys.partition_schemes ps on ps.function_id = pf.function_id
				  left join sys.destination_data_spaces dds
					on dds.partition_scheme_id = ps.data_space_id and dds.destination_id = 1 
				  left join sys.filegroups fg on fg.data_space_id = dds.data_space_id
				  left join sys.partition_range_values prv
					on prv.function_id = pf.function_id and prv.parameter_id = 1 and
					   prv.boundary_id = 1
				 where pf.boundary_value_on_right = 1
				 union all
				select pf.name as [partition_function],
					   ps.name as [partition_scheme],
					   prv.boundary_id + cast(pf.boundary_value_on_right as int) as [partition_number],
					   case when pf.boundary_value_on_right = 0 then '<=' else '>=' end as [relation],
					   prv.value as [boundary_value],
					   type_name(pp.system_type_id) as [type],
					   fg.name as [filegroup],
					   case when ps.name is null then NULL else N'IN USE' end as [status]
				  from sys.partition_functions pf
				  join sys.partition_range_values prv on
					   prv.function_id = pf.function_id and prv.parameter_id = 1
				  join sys.partition_parameters pp on pp.function_id = pf.function_id
				  left join sys.partition_schemes ps on ps.function_id = pf.function_id
				  left join sys.destination_data_spaces dds
					on dds.partition_scheme_id = ps.data_space_id and
					   dds.destination_id = prv.boundary_id + cast(pf.boundary_value_on_right as int)
				  left join sys.filegroups fg on fg.data_space_id = dds.data_space_id
				 union all
				select pf.name as [partition_function],
					   ps.name as [partition_scheme],
					   pf.fanout as [partition_number],
					   case when prv.value is null then NULL else '>' end as [relation],
					   prv.value as [boundary_value],
					   type_name(pp.system_type_id) as [type],
					   fg.name as [filegroup],
					   case when ps.name is null then NULL else N'IN USE' end as [status]
				  from sys.partition_functions pf
				  join sys.partition_parameters pp on pp.function_id = pf.function_id
				  left join sys.partition_schemes ps on ps.function_id = pf.function_id
				  left join sys.destination_data_spaces dds
					on dds.partition_scheme_id = ps.data_space_id and dds.destination_id = pf.fanout 
				  left join sys.filegroups fg on fg.data_space_id = dds.data_space_id
				  left join sys.partition_range_values prv
					on prv.function_id = pf.function_id and prv.parameter_id = 1 and
					   prv.boundary_id = pf.fanout - 1
				 where pf.boundary_value_on_right = 0
				 union all
				select pf.name as [partition_function],
					   ps.name as [partition_scheme],
					   NULL, NULL, NULL, NULL,
					   fg.name as [filegroup],
					   case when dds.destination_id = pf.fanout + 1
							then N'NEXT USED' else N'NOT USED'
					   end as [status]
				  from sys.partition_functions pf
				  join sys.partition_schemes ps on ps.function_id = pf.function_id
				  join sys.destination_data_spaces dds
					on dds.partition_scheme_id = ps.data_space_id and
					   dds.destination_id > pf.fanout
				  join sys.filegroups fg on fg.data_space_id = dds.data_space_id ");
        }

        public DataTable FindStringInsideObjects(string inpString, string DBobjects)
        {
            return DBHelper.ExecuteDT(
                                  @"
                                    SELECT 
	                                    definition, o.name AS Object_Name,
	                                    CASE 
		                                    WHEN [type] = 'TF' THEN 'Table-valued Function'
		                                    WHEN [type] = 'FN' THEN 'Scalar-valued Function'
		                                    WHEN [type] = 'P' THEN 'Store Procedure'
		                                    WHEN [type] = 'TR' THEN 'Trigger'
		                                    WHEN [type] = 'V' THEN 'View'		
	                                    ELSE [type] 
	                                    END ObjectType,
	                                    create_date, modify_date
                                        --o.name AS Object_Name,o.type_desc
                                    FROM sys.sql_modules        m 
                                        INNER JOIN sys.objects  o ON m.object_id=o.object_id
                                    WHERE m.definition Like '%" + inpString + "%' " +
                                    "AND [type] IN(" + DBobjects + ") " +
                                    "ORDER BY 2,1");
        }

        public DataTable GetDatabaseInfo(string dbName)
        {
            return DBHelper.ExecuteDT(
                                @"
                                    SELECT d.status, d.status2, d.category, d.crdate, d.cmptlevel, d.filename
                                    , DATABASEPROPERTYEX(N'AG921115', 'Collation') as cln
                                    , l.name AS owner
                                    , DATABASEPROPERTYEX(N'AG921115', 'Status') as dbstatus, d2.is_trustworthy_on, d2.is_db_chaining_on, d2.is_auto_update_stats_async_on, d2.page_verify_option, d2.snapshot_isolation_state, d2.is_read_committed_snapshot_on, d2.is_supplemental_logging_enabled, d2.is_broker_enabled, d2.is_date_correlation_on, d2.is_parameterization_forced
                                    , d2.is_encrypted
                                        FROM master.dbo.sysdatabases d INNER JOIN sys.databases d2 ON d.dbid = d2.database_id
                                        LEFT OUTER JOIN master.dbo.syslogins l ON l.sid = d.sid
                                        WHERE d.name = N'" + dbName + "'");
        }

        public string getCompatibilityLevel(int num)
        {
            switch (num)
            {
                case 120:
                    return "(SQL Server 2014)";
                    break;
                case 110:
                    return "(SQL Server 2012)";
                    break;
                case 100:
                    return "(SQL Server 2008)";
                    break;
                case 90:
                    return "(SQL Server 2005)";
                    break;
                default:
                    return "(Lower then SQL Server 2005)";
                    break;
            }
        }

        public DataSet getDBSizeInfo()
        {
            return DBHelper.ExecuteDS("EXEC  sp_spaceused");

        }
        
        public DataTable getDatafiles()
        {
            return DBHelper.ExecuteDT(
                @"
                SELECT 
                    -- f.file_id AS id,
                    f.name 'Logical Name',
                    CASE 
	                    WHEN f.type = 0 THEN 'Rows Data'
	                    WHEN f.type = 1 THEN 'Log'
	                    ELSE CAST(f.type AS VARCHAR(2))
                    END 'File Type',
                    f.size / 128 'Initial Size(MB)',
                    -- f.max_size       AS MAXSIZE,
                    f.growth / 128 'Autogrowth(MB)',
                    f.is_percent_growth,
                    f.physical_name  AS FILENAME,
                    g.name           AS groupname
                FROM   sys.database_files f
                LEFT OUTER JOIN 
                    sys.filegroups g ON  f.data_space_id = g.data_space_id
                WHERE  f.type <> 4
                ORDER BY
                f.name OPTION(ROBUST PLAN)
                 ");
        }

        public DataTable getLocalInstance()
        {
            return DBHelper.ExecuteDT
                (
                    @"DECLARE @GetInstances TABLE
                        ( 
                            Value nvarchar(100),
                            InstanceNames nvarchar(100),
                            Data nvarchar(100)
                        )

                        INSERT INTO @GetInstances
                        EXECUTE xp_regread
                          @rootkey = 'HKEY_LOCAL_MACHINE',
                          @key = 'SOFTWARE\Microsoft\Microsoft SQL Server',
                          @value_name = 'InstalledInstances'

                        SELECT InstanceNames 
                        FROM @GetInstances 
                        "
                );
        }



    }
}
