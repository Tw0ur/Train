using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Train.Models;

namespace Train.Repositories
{
    public class ScheduleRepository
    {
        private readonly string connectionString = "Data Source=TWOUR\\SQLEXPRESS;Initial Catalog=secondDB;Integrated Security=True;Trust Server Certificate=True";

        public List<Schedule> GetSchedules()
        {
            var schedules = new List<Schedule>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM Schedule ORDER BY ScheduleID DESC";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Schedule schedule = new Schedule();
                                schedule.ScheduleID = reader.GetInt32(0);
                                schedule.TrainID = reader.GetInt32(1);
                                schedule.DepartureDate = reader.GetDateTime(2);
                                schedule.DepartureTime = reader.GetTimeSpan(3);
                                schedule.DeparturePlace = reader.GetString(4);
                                schedule.ArrivalTime = reader.GetTimeSpan(5);
                                schedule.ArrivalPlace = reader.GetString(6);
                                schedule.Route = reader.GetString(7);
                                schedule.TicketPrice = reader.GetDecimal(8);

                                schedules.Add(schedule);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }

            return schedules;
        }

        

        public Schedule? GetSchedule(int scheduleID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM Schedule WHERE ScheduleID=@ScheduleID";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ScheduleID", scheduleID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Schedule schedule = new Schedule();
                                schedule.ScheduleID = reader.GetInt32(0);
                                schedule.TrainID = reader.GetInt32(1);
                                schedule.DepartureDate = reader.GetDateTime(2);
                                schedule.DepartureTime = reader.GetTimeSpan(3);
                                schedule.DeparturePlace = reader.GetString(4);
                                schedule.ArrivalTime = reader.GetTimeSpan(5);
                                schedule.ArrivalPlace = reader.GetString(6);
                                schedule.Route = reader.GetString(7);
                                schedule.TicketPrice = reader.GetDecimal(8);

                                return schedule;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }

            return null;
        }

        public void CreateSchedule(Schedule schedule)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "INSERT INTO Schedule" +
                                 "(TrainID, DepartureDate, DepartureTime, DeparturePlace, ArrivalTime, ArrivalPlace, Route, TicketPrice) VALUES" +
                                 "(@TrainID, @DepartureDate, @DepartureTime, @DeparturePlace, @ArrivalTime, @ArrivalPlace, @Route, @TicketPrice);";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@TrainID", schedule.TrainID);
                        command.Parameters.AddWithValue("@DepartureDate", schedule.DepartureDate);
                        command.Parameters.AddWithValue("@DepartureTime", schedule.DepartureTime);
                        command.Parameters.AddWithValue("@DeparturePlace", schedule.DeparturePlace);
                        command.Parameters.AddWithValue("@ArrivalTime", schedule.ArrivalTime);
                        command.Parameters.AddWithValue("@ArrivalPlace", schedule.ArrivalPlace);
                        command.Parameters.AddWithValue("@Route", schedule.Route);
                        command.Parameters.AddWithValue("@TicketPrice", schedule.TicketPrice);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        public void UpdateSchedule(Schedule schedule)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "UPDATE Schedule " +
                                 "SET TrainID=@TrainID, DepartureDate=@DepartureDate, DepartureTime=@DepartureTime," +
                                 "DeparturePlace=@DeparturePlace, ArrivalTime=@ArrivalTime, ArrivalPlace=@ArrivalPlace," +
                                 "Route=@Route, TicketPrice=@TicketPrice WHERE ScheduleID=@ScheduleID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@TrainID", schedule.TrainID);
                        command.Parameters.AddWithValue("@DepartureDate", schedule.DepartureDate);
                        command.Parameters.AddWithValue("@DepartureTime", schedule.DepartureTime);
                        command.Parameters.AddWithValue("@DeparturePlace", schedule.DeparturePlace);
                        command.Parameters.AddWithValue("@ArrivalTime", schedule.ArrivalTime);
                        command.Parameters.AddWithValue("@ArrivalPlace", schedule.ArrivalPlace);
                        command.Parameters.AddWithValue("@Route", schedule.Route);
                        command.Parameters.AddWithValue("@TicketPrice", schedule.TicketPrice);
                        command.Parameters.AddWithValue("@ScheduleID", schedule.ScheduleID);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        public void DeleteSchedule(int scheduleID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "DELETE FROM Schedule WHERE ScheduleID=@ScheduleID";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ScheduleID", scheduleID);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}
