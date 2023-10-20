using Cobit_19.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Cobit_19.Data.Seeding
{
    public class MappingTables
    {
        private readonly ModelBuilder _builder;
        public MappingTables(ModelBuilder builder)
        {
            _builder = builder;
        }

        public void generateMapDF1()
        {
            /// Mapping 4 Questions and 40 Objectives with their weights for design factor 1
            float[,] weights1 = new float[,]
            {
                { 1.0f, 1.0f, 1.5f, 1.5f },    // EDM01
                { 1.5f, 1.0f, 2.0f, 3.5f },    // EDM02
                { 1.0f, 1.0f, 1.0f, 2.0f },    // EDM03
                { 1.5f, 1.0f, 4.0f, 1.0f },    // EDM04
                { 1.5f, 1.5f, 1.0f, 2.0f },    // EDM05
                { 1.0f, 1.0f, 1.0f, 1.0f },    // APO01
                { 3.5f, 3.5f, 1.5f, 1.0f },    // APO02
                { 4.0f, 2.0f, 1.0f, 1.0f },    // APO03
                { 1.0f, 4.0f, 1.0f, 1.0f },    // APO04
                { 3.5f, 4.0f, 2.5f, 1.0f },    // APO05
                { 1.5f, 1.0f, 4.0f, 1.0f },    // APO06
                { 2.0f, 1.0f, 1.0f, 1.0f },    // APO07
                { 1.0f, 1.5f, 1.0f, 3.5f },    // APO08
                { 1.0f, 1.0f, 1.5f, 4.0f },    // APO09
                { 1.0f, 1.0f, 3.5f, 1.5f },    // APO10
                { 1.0f, 1.0f, 1.0f, 4.0f },    // APO11
                { 1.0f, 1.5f, 1.0f, 2.5f },    // APO12
                { 1.0f, 1.0f, 1.0f, 2.5f },    // APO13
                { 1.0f, 1.0f, 1.0f, 1.0f },    // APO14
                { 4.0f, 2.0f, 1.5f, 1.5f },    // BAI01
                { 1.0f, 1.0f, 1.5f, 1.0f },    // BAI02
                { 1.0f, 1.0f, 1.5f, 1.0f },    // BAI03
                { 1.0f, 1.0f, 1.0f, 3.0f },    // BAI04
                { 4.0f, 2.0f, 1.0f, 1.5f },    // BAI05
                { 2.0f, 2.0f, 1.0f, 1.5f },    // BAI06
                { 1.5f, 2.0f, 1.0f, 1.5f },    // BAI07
                { 1.0f, 3.5f, 1.0f, 1.0f },    // BAI08
                { 1.0f, 1.0f, 1.0f, 1.0f },    // BAI09
                { 1.0f, 1.0f, 1.0f, 1.0f },    // BAI10
                { 3.5f, 3.0f, 1.5f, 1.0f },    // BAI11
                { 1.0f, 1.0f, 1.0f, 1.5f },    // DSS01
                { 1.0f, 1.0f, 1.0f, 4.0f },    // DSS02
                { 1.0f, 1.0f, 1.0f, 3.0f },    // DSS03
                { 1.0f, 1.0f, 1.0f, 4.0f },    // DSS04
                { 1.0f, 1.0f, 1.0f, 2.5f },    // DSS05
                { 1.0f, 1.0f, 1.0f, 1.5f },    // DSS06
                { 1.0f, 1.0f, 1.0f, 1.0f },    // MEA01
                { 1.0f, 1.0f, 1.0f, 1.0f },    // MEA02
                { 1.0f, 1.0f, 1.0f, 1.0f },    // MEA03
                { 1.0f, 1.0f, 1.0f, 1.0f }     // MEA04
            };

            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    {
                        float dsweight1 = weights1[i, j];
                        _builder.Entity<MapModel>().HasData(
                        new MapModel { QuestionID = j + 1, ObjectiveID = i + 1, Weight = dsweight1 }
                        );
                    };
                }
            }
        }

        public void generateMapDF2()
        {
            /// Mapping 12 Questions and 40 Objectives with their weights for design factor 2
            // Define the weights as a 2D array
            float[,] weights2 = new float[,]
            {
                { 4.0f,  4.0f,  4.0f,  0.0f,  4.0f,  1.0f,  0.0f,  3.0f,  2.0f,  1.0f,  3.0f,  6.0f,  1.0f }, // EDM01
                { 10.0f, 0.0f,  0.0f,  0.0f,  6.0f,  1.0f,  0.0f,  5.0f,  2.0f,  1.0f,  0.0f,  9.0f,  4.0f }, // EDM02
                { 0.0f,  8.0f,  4.0f,  0.0f,  0.0f,  6.0f,  0.0f,  0.0f,  0.0f,  0.0f,  3.0f,  0.0f,  0.0f }, // EDM03
                { 11.0f, 0.0f,  0.0f,  0.0f,  7.0f,  1.0f,  0.0f,  6.0f,  3.0f,  1.0f,  0.0f,  10.0f, 4.0f }, // EDM04
                { 0.0f,  1.0f,  2.0f,  6.0f,  0.0f,  0.0f,  6.0f,  0.0f,  4.0f,  0.0f,  2.0f,  0.0f,  0.0f }, // EDM05
                { 8.0f,  6.0f,  6.0f,  2.0f,  6.0f,  4.0f,  2.0f,  5.0f,  4.0f,  1.0f,  5.0f,  9.0f,  2.0f }, // APO01
                { 11.0f, 0.0f,  0.0f,  0.0f,  8.0f,  1.0f,  0.0f,  5.0f,  1.0f,  4.0f,  0.0f,  9.0f,  5.0f }, // APO02
                { 11.0f, 1.0f,  0.0f,  0.0f,  8.0f,  3.0f,  0.0f,  6.0f,  1.0f,  2.0f,  0.0f,  9.0f,  4.0f }, // APO03
                { 11.0f, 0.0f,  0.0f,  0.0f,  6.0f,  0.0f,  0.0f,  4.0f,  1.0f,  3.0f,  0.0f,  8.0f,  7.0f }, // APO04
                { 12.0f, 0.0f,  0.0f,  0.0f,  8.0f,  2.0f,  0.0f,  7.0f,  3.0f,  1.0f,  0.0f,  11.0f, 3.0f }, // APO05
                { 5.0f,  0.0f,  0.0f,  6.0f,  3.0f,  0.0f,  6.0f,  3.0f,  8.0f,  0.0f,  0.0f,  6.0f,  2.0f }, // APO06
                { 9.0f,  0.0f,  0.0f,  0.0f,  5.0f,  1.0f,  0.0f,  3.0f,  2.0f,  4.0f,  0.0f,  7.0f,  5.0f }, // APO07
                { 17.0f, 0.0f,  0.0f,  0.0f,  10.0f, 2.0f,  0.0f,  7.0f,  2.0f,  5.0f,  0.0f,  12.0f, 8.0f }, // APO08
                { 6.0f,  0.0f,  0.0f,  0.0f,  4.0f,  2.0f,  0.0f,  3.0f,  0.0f,  1.0f,  0.0f,  4.0f,  1.0f }, // APO09
                { 8.0f,  0.0f,  0.0f,  0.0f,  4.0f,  2.0f,  0.0f,  4.0f,  1.0f,  0.0f,  0.0f,  5.0f,  2.0f }, // APO10
                { 7.0f,  0.0f,  0.0f,  6.0f,  4.0f,  1.0f,  6.0f,  4.0f,  7.0f,  0.0f,  0.0f,  7.0f,  2.0f }, // APO11
                { 0.0f,  6.0f,  0.0f,  0.0f,  0.0f,  6.0f,  0.0f,  0.0f,  0.0f,  0.0f,  0.0f,  0.0f,  0.0f }, // APO12
                { 0.0f,  5.0f,  2.0f,  0.0f,  0.0f,  5.0f,  0.0f,  0.0f,  0.0f,  0.0f,  1.0f,  0.0f,  0.0f }, // APO13
                { 0.0f,  4.0f,  2.0f,  6.0f,  0.0f,  3.0f,  6.0f,  0.0f,  4.0f,  0.0f,  1.0f,  0.0f,  0.0f }, // APO14
                { 10.0f, 0.0f,  0.0f,  0.0f,  7.0f,  0.0f,  0.0f,  6.0f,  4.0f,  1.0f,  0.0f,  11.0f, 4.0f }, // BAI01
                { 15.0f, 0.0f,  0.0f,  0.0f,  10.0f, 2.0f,  0.0f,  8.0f,  3.0f,  3.0f,  0.0f,  12.0f, 5.0f }, // BAI02
                { 15.0f, 0.0f,  0.0f,  0.0f,  9.0f,  2.0f,  0.0f,  8.0f,  3.0f,  1.0f,  0.0f,  12.0f, 5.0f }, // BAI03
                { 6.0f,  1.0f,  0.0f,  0.0f,  3.0f,  4.0f,  0.0f,  3.0f,  1.0f,  0.0f,  0.0f,  4.0f,  1.0f }, // BAI04
                { 14.0f, 0.0f,  0.0f,  0.0f,  11.0f, 1.0f,  0.0f,  8.0f,  4.0f,  4.0f,  0.0f,  14.0f, 5.0f }, // BAI05
                { 8.0f,  2.0f,  0.0f,  0.0f,  5.0f,  2.0f,  0.0f,  4.0f,  0.0f,  1.0f,  0.0f,  5.0f,  3.0f }, // BAI06
                { 6.0f,  2.0f,  0.0f,  0.0f,  3.0f,  1.0f,  0.0f,  3.0f,  1.0f,  0.0f,  0.0f,  4.0f,  3.0f }, // BAI07
                { 11.0f, 0.0f,  0.0f,  0.0f,  7.0f,  0.0f,  0.0f,  4.0f,  2.0f,  5.0f,  0.0f,  9.0f,  7.0f }, // BAI08
                { 0.0f,  0.0f,  0.0f,  6.0f,  0.0f,  0.0f,  6.0f,  0.0f,  5.0f,  0.0f,  0.0f,  0.0f,  0.0f }, // BAI09
                { 2.0f,  0.0f,  0.0f,  0.0f,  1.0f,  1.0f,  0.0f,  1.0f,  0.0f,  0.0f,  0.0f,  1.0f,  0.0f }, // BAI10
                { 12.0f, 0.0f,  0.0f,  0.0f,  7.0f,  1.0f,  0.0f,  7.0f,  4.0f,  0.0f,  0.0f,  11.0f, 4.0f }, // BAI11
                { 6.0f,  0.0f,  0.0f,  0.0f,  4.0f,  2.0f,  0.0f,  3.0f,  0.0f,  1.0f,  0.0f,  4.0f,  1.0f }, // DSS01
                { 4.0f,  3.0f,  0.0f,  0.0f,  2.0f,  5.0f,  0.0f,  2.0f,  0.0f,  0.0f,  0.0f,  2.0f,  0.0f }, // DSS02
                { 4.0f,  3.0f,  0.0f,  0.0f,  2.0f,  5.0f,  0.0f,  2.0f,  0.0f,  0.0f,  0.0f,  2.0f,  0.0f }, // DSS03
                { 4.0f,  3.0f,  0.0f,  0.0f,  2.0f,  5.0f,  0.0f,  2.0f,  0.0f,  0.0f,  0.0f,  2.0f,  0.0f }, // DSS04
                { 2.0f,  8.0f,  4.0f,  0.0f,  1.0f,  7.0f,  0.0f,  1.0f,  0.0f,  0.0f,  3.0f,  1.0f,  0.0f }, // DSS05
                { 6.0f,  4.0f,  2.0f,  0.0f,  5.0f,  4.0f,  0.0f,  3.0f,  0.0f,  2.0f,  2.0f,  5.0f,  2.0f }, // DSS06
                { 7.0f,  2.0f,  4.0f,  4.0f,  4.0f,  2.0f,  4.0f,  4.0f,  4.0f,  0.0f,  3.0f,  6.0f,  1.0f }, // MEA01
                { 4.0f,  6.0f,  6.0f,  4.0f,  2.0f,  4.0f,  4.0f,  2.0f,  4.0f,  0.0f,  5.0f,  3.0f,  1.0f }, // MEA02
                { 0.0f,  3.0f,  6.0f,  0.0f,  0.0f,  0.0f,  0.0f,  0.0f,  0.0f,  0.0f,  4.0f,  0.0f,  0.0f }, // MEA03
                { 2.0f,  6.0f,  6.0f,  4.0f,  1.0f,  4.0f,  4.0f,  1.0f,  3.0f,  0.0f,  5.0f,  1.0f,  0.0f }  // MEA04
            };

            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    {
                        float dsweight2 = weights2[i, j];
                        _builder.Entity<MapModel>().HasData(
                        new MapModel { QuestionID = j + 5, ObjectiveID = i + 1, Weight = dsweight2 }
                        );
                    };
                }
            }
        }

        public void generateMapDF3()
        {
            /// Mapping 19 Questions and 40 Objectives with their weights for design factor 3
            float[,] weights3 = new float[,]
            {
                { 3.0f, 2.0f, 3.0f, 0.0f, 0.0f, 0.0f, 2.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 3.0f, 2.0f, 0.0f, 0.0f, 2.0f, 2.0f, 2.0f }, // EDM01
                { 3.0f, 2.0f, 0.0f, 0.0f, 2.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 1.0f, 0.0f, 0.0f, 0.0f, 3.0f, 1.0f, 3.0f }, // EDM02
                { 2.0f, 2.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 1.0f, 2.0f, 0.0f, 3.0f, 3.0f, 0.0f, 0.0f, 0.0f, 2.0f, 3.0f }, // EDM03
                { 3.0f, 0.0f, 4.0f, 3.0f, 2.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 2.0f, 1.0f, 0.0f, 2.0f, 0.0f, 0.0f, 2.0f, 3.0f }, // EDM04
                { 3.0f, 1.0f, 3.0f, 0.0f, 0.0f, 0.0f, 2.0f, 0.0f, 0.0f, 1.0f, 0.0f, 1.0f, 3.0f, 3.0f, 0.0f, 0.0f, 0.0f, 2.0f, 2.0f }, // EDM05
                { 2.0f, 3.0f, 2.0f, 0.0f, 2.0f, 2.0f, 4.0f, 2.0f, 0.0f, 2.0f, 3.0f, 3.0f, 3.0f, 0.0f, 0.0f, 0.0f, 3.0f, 2.0f, 3.0f }, // APO01
                { 2.0f, 0.0f, 0.0f, 0.0f, 3.0f, 0.0f, 0.0f, 2.0f, 1.0f, 0.0f, 1.0f, 2.0f, 0.0f, 0.0f, 0.0f, 0.0f, 2.0f, 2.0f, 1.0f }, // APO02
                { 2.0f, 0.0f, 0.0f, 0.0f, 4.0f, 0.0f, 0.0f, 2.0f, 0.0f, 2.0f, 2.0f, 2.0f, 0.0f, 0.0f, 0.0f, 0.0f, 2.0f, 0.0f, 3.0f }, // APO03
                { 0.0f, 0.0f, 0.0f, 0.0f, 1.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 4.0f, 0.0f, 0.0f }, // APO04
                { 4.0f, 2.0f, 2.0f, 0.0f, 2.0f, 0.0f, 0.0f, 2.0f, 2.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 2.0f, 0.0f, 0.0f }, // APO05
                { 2.0f, 3.0f, 4.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 2.0f, 0.0f, 2.0f, 0.0f, 0.0f, 2.0f, 2.0f, 0.0f }, // APO06
                { 0.0f, 0.0f, 0.0f, 4.0f, 0.0f, 2.0f, 3.0f, 3.0f, 0.0f, 0.0f, 2.0f, 0.0f, 0.0f, 2.0f, 4.0f, 0.0f, 2.0f, 2.0f, 0.0f }, // APO07
                { 0.0f, 0.0f, 0.0f, 2.0f, 2.0f, 0.0f, 0.0f, 4.0f, 0.0f, 0.0f, 2.0f, 2.0f, 0.0f, 0.0f, 0.0f, 0.0f, 3.0f, 0.0f, 2.0f }, // APO08
                { 0.0f, 0.0f, 2.0f, 0.0f, 0.0f, 0.0f, 2.0f, 3.0f, 0.0f, 1.0f, 2.0f, 3.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f }, // APO09
                { 0.0f, 2.0f, 3.0f, 0.0f, 0.0f, 0.0f, 2.0f, 2.0f, 3.0f, 2.0f, 2.0f, 4.0f, 2.0f, 2.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f }, // APO10
                { 0.0f, 3.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 2.0f, 0.0f, 4.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 2.0f }, // APO11
                { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 3.0f, 0.0f, 0.0f, 2.0f, 3.0f, 0.0f, 0.0f, 0.0f, 0.0f, 2.0f, 0.0f, 0.0f, 0.0f }, // APO12
                { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 4.0f, 0.0f, 0.0f, 0.0f, 4.0f, 0.0f, 3.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f }, // APO13
                { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 3.0f, 2.0f, 0.0f, 0.0f, 2.0f, 0.0f, 3.0f, 0.0f, 2.0f, 4.0f, 2.0f, 0.0f, 4.0f }, // APO14
                { 0.0f, 4.0f, 0.0f, 0.0f, 2.0f, 0.0f, 0.0f, 3.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f }, // BAI01
                { 2.0f, 2.0f, 0.0f, 0.0f, 2.0f, 0.0f, 0.0f, 3.0f, 0.0f, 2.0f, 2.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f }, // BAI02
                { 0.0f, 3.0f, 0.0f, 0.0f, 2.0f, 0.0f, 0.0f, 2.0f, 0.0f, 3.0f, 3.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f }, // BAI03
                { 0.0f, 1.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f }, // BAI04
                { 0.0f, 2.0f, 0.0f, 2.0f, 0.0f, 0.0f, 0.0f, 4.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f }, // BAI05
                { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 3.0f, 4.0f, 0.0f, 0.0f, 2.0f, 3.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 3.0f }, // BAI06
                { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 2.0f, 3.0f, 2.0f, 0.0f, 4.0f, 2.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f }, // BAI07
                { 0.0f, 0.0f, 0.0f, 2.0f, 0.0f, 3.0f, 0.0f, 3.0f, 0.0f, 3.0f, 0.0f, 0.0f, 0.0f, 0.0f, 2.0f, 0.0f, 0.0f, 0.0f, 2.0f }, // BAI08
                { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 1.0f, 3.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f }, // BAI09
                { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 2.0f, 4.0f, 0.0f, 0.0f, 2.0f, 3.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f }, // BAI10
                { 0.0f, 4.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f }, // BAI11
                { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 4.0f, 3.0f, 0.0f, 4.0f, 0.0f, 2.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 2.0f, 0.0f }, // DSS01
                { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 3.0f, 2.0f, 3.0f, 2.0f, 2.0f, 4.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f }, // DSS02
                { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 3.0f, 1.0f, 4.0f, 0.0f, 3.0f, 1.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f }, // DSS03
                { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 3.0f, 3.0f, 0.0f, 3.0f, 0.0f, 4.0f, 0.0f, 2.0f, 0.0f, 3.0f, 4.0f, 0.0f, 0.0f, 2.0f }, // DSS04
                { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 3.0f, 4.0f, 0.0f, 2.0f, 0.0f, 4.0f, 0.0f, 3.0f, 0.0f, 3.0f, 2.0f, 0.0f, 0.0f, 3.0f }, // DSS05
                { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 3.0f, 4.0f, 2.0f, 0.0f, 0.0f, 2.0f, 0.0f, 2.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 3.0f }, // DSS06
                { 1.0f, 2.0f, 2.0f, 0.0f, 0.0f, 2.0f, 2.0f, 0.0f, 0.0f, 2.0f, 3.0f, 2.0f, 2.0f, 2.0f, 0.0f, 2.0f, 0.0f, 0.0f, 2.0f }, // MEA01
                { 1.0f, 2.0f, 2.0f, 0.0f, 0.0f, 3.0f, 3.0f, 0.0f, 0.0f, 2.0f, 3.0f, 2.0f, 2.0f, 3.0f, 0.0f, 2.0f, 0.0f, 0.0f, 2.0f }, // MEA02
                { 0.0f, 1.0f, 0.0f, 0.0f, 0.0f, 1.0f, 2.0f, 0.0f, 0.0f, 0.0f, 3.0f, 2.0f, 4.0f, 2.0f, 0.0f, 0.0f, 0.0f, 0.0f, 2.0f }, // MEA03
                { 1.0f, 2.0f, 0.0f, 0.0f, 0.0f, 0.0f, 3.0f, 0.0f, 0.0f, 2.0f, 3.0f, 2.0f, 2.0f, 4.0f, 0.0f, 2.0f, 2.0f, 0.0f, 0.0f }  // MEA04

            };

            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    {
                        float dsweight3 = weights3[i, j];
                        _builder.Entity<MapModel>().HasData(
                        new MapModel { ObjectiveID = i + 1, QuestionID = j + 18, Weight = dsweight3 }
                        );
                    };

                }
            }
        }

        public void generateMapDF4()
        {
            /// Mapping 20 Questions and 40 Objectives with their weights for design factor 4
            float[,] weights4 = new float[,]
            {
                { 3.0f, 3.0f, 1.0f, 1.0f, 2.0f, 2.0f, 2.0f, 1.0f, 1.0f, 1.0f, 3.0f, 3.5f, 1.0f, 1.0f, 1.0f, 1.0f, 2.0f, 3.0f, 1.5f, 1.0f },    // EDM01
                { 2.5f, 3.0f, 1.0f, 1.0f, 1.5f, 2.5f, 2.0f, 1.5f, 0.5f, 2.5f, 1.5f, 1.0f, 3.0f, 2.0f, 1.0f, 1.0f, 2.0f, 2.0f, 1.0f, 2.5f },    // EDM02
                { 1.0f, 1.0f, 2.0f, 1.0f, 2.0f, 2.0f, 1.0f, 1.0f, 0.0f, 0.5f, 1.0f, 0.0f, 1.0f, 1.5f, 1.0f, 2.5f, 1.0f, 1.0f, 2.5f, 1.0f },    // EDM03
                { 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 2.0f, 3.0f, 3.5f, 3.5f, 1.0f, 1.5f, 0.0f, 4.0f, 2.0f, 1.0f, 1.5f, 2.0f, 2.5f, 0.0f, 1.0f },    // EDM04
                { 1.0f, 1.0f, 1.0f, 1.0f, 1.5f, 2.0f, 1.0f, 1.0f, 0.0f, 1.0f, 3.0f, 1.5f, 1.5f, 0.5f, 0.5f, 0.5f, 1.0f, 1.0f, 1.0f, 0.0f },    // EDM05


                { 2.0f, 1.0f, 2.0f, 1.0f, 2.0f, 2.0f, 1.0f, 1.0f, 0.0f, 0.5f, 1.5f, 4.0f, 1.0f, 2.0f, 1.0f, 1.0f, 1.5f, 2.0f, 0.5f, 1.0f },    // APO01
                { 1.5f, 1.5f, 1.5f, 1.5f, 1.0f, 1.5f, 1.0f, 1.0f, 0.0f, 1.0f, 2.5f, 0.5f, 0.5f, 1.5f, 1.5f, 0.5f, 2.0f, 2.0f, 0.0f, 2.5f },    // APO02
                { 1.0f, 1.5f, 1.0f, 2.0f, 0.5f, 1.5f, 2.0f, 1.5f, 1.0f, 3.5f, 0.5f, 0.5f, 1.0f, 4.0f, 1.0f, 3.5f, 2.0f, 3.0f, 0.0f, 2.0f },    // APO03
                { 1.0f, 1.0f, 1.0f, 1.0f, 0.5f, 0.5f, 0.5f, 0.5f, 0.0f, 0.0f, 0.5f, 1.0f, 0.5f, 2.0f, 1.0f, 0.0f, 0.5f, 0.5f, 0.0f, 4.0f },    // APO04
                { 3.0f, 3.0f, 1.0f, 1.5f, 2.0f, 2.0f, 1.5f, 3.5f, 0.5f, 2.0f, 2.0f, 1.5f, 2.0f, 1.0f, 0.5f, 0.0f, 2.5f, 2.5f, 0.0f, 2.0f },    // APO05

                { 3.5f, 2.0f, 1.0f, 1.5f, 1.5f, 2.0f, 4.0f, 3.0f, 1.0f, 2.0f, 1.0f, 1.5f, 4.0f, 0.0f, 0.0f, 0.0f, 1.0f, 2.0f, 0.0f, 0.0f },    // APO06
                { 1.5f, 1.0f, 1.0f, 1.0f, 1.0f, 1.5f, 2.0f, 2.0f, 4.0f, 1.0f, 0.0f, 0.0f, 1.0f, 0.0f, 3.0f, 0.0f, 0.5f, 0.5f, 1.5f, 1.0f },    // APO07
                { 2.5f, 2.0f, 1.0f, 2.5f, 1.5f, 1.0f, 2.5f, 2.0f, 1.5f, 1.0f, 3.0f, 1.0f, 0.5f, 1.0f, 4.0f, 1.0f, 3.0f, 3.5f, 0.0f, 0.5f },    // APO08
                { 2.0f, 1.5f, 2.0f, 4.0f, 1.0f, 2.5f, 1.5f, 2.0f, 0.5f, 1.0f, 0.0f, 0.0f, 1.0f, 0.0f, 0.0f, 0.0f, 1.0f, 1.5f, 0.0f, 0.0f },    // APO09
                { 1.0f, 1.0f, 2.0f, 4.0f, 1.5f, 1.5f, 1.5f, 1.0f, 1.5f, 1.0f, 0.0f, 0.0f, 1.0f, 0.0f, 0.0f, 0.0f, 0.5f, 2.0f, 1.0f, 0.0f },    // APO10

                { 1.0f, 1.0f, 3.0f, 1.5f, 1.0f, 3.0f, 0.0f, 0.0f, 0.0f, 2.0f, 0.0f, 0.0f, 0.0f, 0.5f, 0.5f, 3.0f, 2.0f, 2.0f, 0.0f, 1.0f },    // APO11
                { 1.0f, 0.5f, 2.5f, 1.5f, 2.0f, 2.0f, 1.0f, 1.0f, 0.5f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 2.0f, 1.0f, 1.5f, 2.5f, 1.0f },    // APO12
                { 0.0f, 0.0f, 3.5f, 1.0f, 2.0f, 1.0f, 0.0f, 1.0f, 0.0f, 0.5f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 1.5f, 2.0f, 1.0f, 2.0f, 1.0f },    // APO13
                { 1.0f, 1.0f, 3.0f, 1.0f, 2.5f, 1.5f, 1.0f, 1.5f, 0.0f, 1.5f, 0.0f, 0.0f, 0.5f, 2.5f, 0.5f, 4.0f, 2.5f, 2.0f, 3.0f, 0.0f },    // APO14

                { 0.0f, 1.0f, 1.5f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 3.0f, 1.0f, 3.5f, 0.0f, 0.0f, 1.5f, 0.0f, 0.0f, 1.5f, 2.0f, 0.0f, 1.0f },    // BAI01
                { 0.0f, 3.0f, 0.0f, 0.0f, 0.5f, 0.5f, 2.0f, 0.0f, 2.0f, 0.0f, 3.5f, 0.0f, 1.0f, 1.0f, 2.0f, 1.5f, 2.5f, 3.0f, 0.5f, 1.0f },    // BAI02
                { 1.0f, 2.0f, 2.0f, 0.0f, 0.0f, 0.0f, 2.0f, 0.0f, 1.0f, 0.0f, 3.0f, 0.0f, 0.5f, 1.0f, 1.0f, 0.5f, 2.0f, 2.0f, 1.0f, 0.5f },    // BAI03
                { 0.5f, 0.0f, 2.0f, 3.0f, 0.0f, 0.0f, 2.0f, 0.0f, 0.5f, 0.0f, 0.0f, 0.0f, 0.0f, 0.5f, 0.0f, 1.0f, 1.0f, 1.0f, 0.0f, 0.5f },    // BAI04

                { 1.0f, 3.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.5f, 0.0f, 3.0f, 1.0f, 0.0f, 0.0f, 0.5f, 2.0f, 0.0f, 0.5f, 1.5f, 0.0f, 1.0f },    // BAI05
                { 0.0f, 0.0f, 2.5f, 3.0f, 0.5f, 1.5f, 0.0f, 1.0f, 0.0f, 1.5f, 0.0f, 1.0f, 0.5f, 1.0f, 0.5f, 2.0f, 2.0f, 2.0f, 1.0f, 1.0f },    // BAI06
                { 0.0f, 1.0f, 2.0f, 2.0f, 0.5f, 1.5f, 0.0f, 0.5f, 0.0f, 2.0f, 0.0f, 1.0f, 0.0f, 1.0f, 0.5f, 2.0f, 2.0f, 2.0f, 0.0f, 1.0f },    // BAI07
                { 0.0f, 0.0f, 0.0f, 1.5f, 0.5f, 0.5f, 0.0f, 1.0f, 2.0f, 0.5f, 0.0f, 0.5f, 0.0f, 1.0f, 3.0f, 2.0f, 1.0f, 1.5f, 0.0f, 0.5f },    // BAI08


                { 0.5f, 0.5f, 1.0f, 0.0f, 0.0f, 0.0f, 2.0f, 2.0f, 0.0f, 0.0f, 0.0f, 0.0f, 2.0f, 1.0f, 0.0f, 0.0f, 1.0f, 1.5f, 0.0f, 0.0f },    // BAI09
                { 0.0f, 0.0f, 2.5f, 2.0f, 0.5f, 0.0f, 0.0f, 0.5f, 0.0f, 0.0f, 0.0f, 0.0f, 1.0f, 1.5f, 0.0f, 1.5f, 1.0f, 2.0f, 0.0f, 0.0f },    // BAI10
                { 1.0f, 2.0f, 2.5f, 0.0f, 0.0f, 0.0f, 2.0f, 3.0f, 1.0f, 4.0f, 0.0f, 0.0f, 1.5f, 2.0f, 0.5f, 0.0f, 1.0f, 1.5f, 0.0f, 0.5f },    // BAI11

                { 0.0f, 0.0f, 2.5f, 2.0f, 1.0f, 2.0f, 0.0f, 0.5f, 0.0f, 0.0f, 0.0f, 0.0f, 1.0f, 0.0f, 0.0f, 1.5f, 1.0f, 2.0f, 0.0f, 0.0f },    // DSS01
                { 1.0f, 1.0f, 4.0f, 3.0f, 1.0f, 2.5f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 1.0f, 0.0f, 0.0f, 1.0f, 1.0f, 1.0f, 0.0f, 0.0f },    // DSS02
                { 0.0f, 1.0f, 3.0f, 3.0f, 0.0f, 3.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 1.0f, 1.5f, 1.0f, 1.0f, 1.0f, 0.5f, 0.0f },    // DSS03

                { 0.0f, 0.0f, 3.0f, 1.0f, 2.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 1.5f, 1.0f, 2.0f, 0.0f, 0.0f },    // DSS04
                { 0.0f, 0.0f, 4.0f, 2.0f, 2.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 1.5f, 1.0f, 2.0f, 2.0f, 0.0f },    // DSS05
                { 0.0f, 1.0f, 0.5f, 0.0f, 3.0f, 0.5f, 0.0f, 0.0f, 0.0f, 1.0f, 0.0f, 0.0f, 0.0f, 0.0f, 1.5f, 2.5f, 1.5f, 1.0f, 2.0f, 0.0f },    // DSS06

                { 1.0f, 1.5f, 2.0f, 2.0f, 2.5f, 3.0f, 1.0f, 2.0f, 1.5f, 1.0f, 1.0f, 1.0f, 2.0f, 1.0f, 1.0f, 1.0f, 1.5f, 1.0f, 2.5f, 1.0f },    // MEA01
                { 0.0f, 0.0f, 2.0f, 2.0f, 2.5f, 2.0f, 2.0f, 0.0f, 0.5f, 2.0f, 1.0f, 1.0f, 1.5f, 1.0f, 0.0f, 2.0f, 1.0f, 1.0f, 2.5f, 0.0f },    // MEA02
                { 0.0f, 0.0f, 2.0f, 2.0f, 4.0f, 0.5f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 2.0f, 0.0f, 0.0f, 4.0f, 0.0f },    // MEA03
                { 1.0f, 1.0f, 3.0f, 1.5f, 3.0f, 4.0f, 2.0f, 1.0f, 1.0f, 0.5f, 1.0f, 1.0f, 1.5f, 0.0f, 1.0f, 1.0f, 1.0f, 1.0f, 2.5f, 1.0f }     // MEA04
            };

            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    {
                        float dsweight4 = weights4[i, j];
                        _builder.Entity<MapModel>().HasData(
                        new MapModel { ObjectiveID = i + 1, QuestionID = j + 37, Weight = dsweight4 }
                        );
                    };
                }
            }
        }

        public void generateMapDF5()
        {
            /// Mapping 2 Questions and 40 Objectives with their weights for design factor 5
            float[,] weights5 = new float[,]
            {
                { 3.0f, 1.0f },    // EDM01
                { 1.0f, 1.0f },    // EDM02
                { 4.0f, 1.0f },    // EDM03
                { 1.5f, 1.0f },    // EDM04
                { 2.0f, 1.0f },    // EDM05
                { 3.0f, 1.0f },    // APO01
                { 1.0f, 1.0f },    // APO02
                { 3.0f, 1.0f },    // APO03
                { 1.0f, 1.0f },    // APO04
                { 1.0f, 1.0f },    // APO05
                { 1.0f, 1.0f },    // APO06
                { 2.0f, 1.0f },    // APO07
                { 1.0f, 1.0f },    // APO08
                { 2.0f, 1.0f },    // APO09
                { 3.0f, 1.0f },    // APO10
                { 2.0f, 1.0f },    // APO11
                { 4.0f, 1.0f },    // APO12
                { 4.0f, 1.0f },    // APO13
                { 3.0f, 1.0f },    // APO14
                { 1.0f, 1.0f },    // BAI01
                { 1.0f, 1.0f },    // BAI02
                { 1.0f, 1.0f },    // BAI03
                { 2.0f, 1.0f },    // BAI04
                { 1.0f, 1.0f },    // BAI05
                { 3.0f, 1.0f },    // BAI06
                { 1.0f, 1.0f },    // BAI07
                { 1.0f, 1.5f },    // BAI08
                { 1.0f, 1.0f },    // BAI09
                { 3.0f, 1.0f },    // BAI10
                { 1.0f, 1.0f },    // BAI11
                { 1.0f, 1.0f },    // DSS01
                { 3.0f, 1.0f },    // DSS02
                { 2.0f, 1.0f },    // DSS03
                { 4.0f, 1.0f },    // DSS04
                { 3.0f, 1.0f },    // DSS05
                { 3.0f, 1.0f },    // DSS06
                { 3.0f, 1.0f },    // MEA01
                { 2.0f, 1.0f },    // MEA02
                { 3.0f, 1.0f },    // MEA03
                { 3.0f, 1.0f }     // MEA04
            };

            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    {
                        float dsweight5 = weights5[i, j];
                        _builder.Entity<MapModel>().HasData(
                        new MapModel { ObjectiveID = i + 1, QuestionID = j + 57, Weight = dsweight5 }
                        );
                    };
                }
            }
        }

        public void generateMapDF6()
        {
            float[,] weights6 = new float[,]
            {
                { 3.0f, 2.0f, 1.0f },    // EDM01
                { 1.0f, 1.0f, 1.0f },    // EDM02
                { 4.0f, 2.0f, 1.0f },    // EDM03
                { 1.0f, 1.0f, 1.0f },    // EDM04
                { 1.5f, 1.0f, 1.0f },    // EDM05
                { 2.0f, 1.5f, 1.0f },    // APO01
                { 1.0f, 1.0f, 1.0f },    // APO02
                { 1.0f, 1.0f, 1.0f },    // APO03
                { 1.0f, 1.0f, 1.0f },    // APO04
                { 1.0f, 1.0f, 1.0f },    // APO05
                { 1.0f, 1.0f, 1.0f },    // APO06
                { 1.0f, 1.0f, 1.0f },    // APO07
                { 1.0f, 1.0f, 1.0f },    // APO08
                { 1.0f, 1.0f, 1.0f },    // APO09
                { 1.5f, 1.0f, 1.0f },    // APO10
                { 1.0f, 1.0f, 1.0f },    // APO11
                { 4.0f, 2.0f, 1.0f },    // APO12
                { 1.5f, 1.0f, 1.0f },    // APO13
                { 2.0f, 1.5f, 1.0f },    // APO14
                { 1.0f, 1.0f, 1.0f },    // BAI01
                { 1.0f, 1.0f, 1.0f },    // BAI02
                { 1.0f, 1.0f, 1.0f },    // BAI03
                { 1.0f, 1.0f, 1.0f },    // BAI04
                { 1.0f, 1.0f, 1.0f },    // BAI05
                { 1.0f, 1.0f, 1.0f },    // BAI06
                { 1.0f, 1.0f, 1.0f },    // BAI07
                { 1.0f, 1.5f, 1.5f },    // BAI08
                { 1.0f, 1.0f, 1.0f },    // BAI09
                { 1.0f, 1.0f, 1.0f },    // BAI10
                { 1.0f, 1.0f, 1.0f },    // BAI11
                { 1.0f, 1.0f, 1.0f },    // DSS01
                { 1.0f, 1.0f, 1.0f },    // DSS02
                { 1.0f, 1.0f, 1.0f },    // DSS03
                { 1.0f, 1.0f, 1.0f },    // DSS04
                { 2.0f, 1.0f, 1.0f },    // DSS05
                { 1.0f, 1.0f, 1.0f },    // DSS06
                { 1.0f, 1.0f, 1.0f },    // MEA01
                { 1.0f, 1.0f, 1.0f },    // MEA02
                { 4.0f, 2.0f, 1.0f },    // MEA03
                { 3.5f, 2.0f, 1.0f }     // MEA04
            };

            //nested for loop for all the 40 Objectives
            for (int i = 0; i < 40; i++)
            {
                // j<3 - set of questions
                for (int j = 0; j < 3; j++)
                {
                    {
                        float dsweight6 = weights6[i, j];
                        _builder.Entity<MapModel>().HasData(
                        new MapModel { ObjectiveID = i + 1, QuestionID = j + 59, Weight = dsweight6 }
                        );
                    };
                }
            }
        }

        public void generateMapDF7()
        {
            /// Mapping 4 Questions and 40 Objectives with their weights for design factor 7
            float[,] weights7 = new float[,]
            {
                { 1.0f, 2.0f, 1.5f, 4.0f },  // EDM01
                { 1.0f, 1.0f, 2.5f, 3.0f },  // EDM02
                { 1.0f, 3.0f, 1.0f, 3.0f },  // EDM03
                { 1.0f, 1.0f, 1.0f, 2.0f },  // EDM04
                { 1.0f, 1.0f, 1.0f, 2.0f },  // EDM05
                { 1.0f, 1.5f, 1.5f, 2.5f },  // APO01
                { 1.0f, 1.0f, 3.0f, 3.0f },  // APO02
                { 1.0f, 1.0f, 2.0f, 2.0f },  // APO03
                { 0.5f, 1.0f, 3.5f, 4.0f },  // APO04
                { 1.0f, 1.0f, 2.5f, 3.0f },  // APO05
                { 1.0f, 1.0f, 1.0f, 2.0f },  // APO06
                { 1.0f, 1.0f, 1.0f, 1.5f },  // APO07
                { 1.0f, 1.0f, 2.0f, 2.5f },  // APO08
                { 1.0f, 2.0f, 1.5f, 2.0f },  // APO09
                { 1.0f, 2.5f, 1.5f, 2.0f },  // APO10
                { 1.0f, 1.5f, 1.5f, 2.0f },  // APO11
                { 1.0f, 2.5f, 1.0f, 3.0f },  // APO12
                { 1.0f, 2.0f, 1.5f, 3.0f },  // APO13
                { 1.0f, 1.5f, 1.5f, 2.5f },  // APO14
                { 1.0f, 1.0f, 2.0f, 2.5f },  // BAI01
                { 1.0f, 1.0f, 3.0f, 3.0f },  // BAI02
                { 1.0f, 1.0f, 3.0f, 3.0f },  // BAI03
                { 1.0f, 2.5f, 1.5f, 2.0f },  // BAI04
                { 1.0f, 1.0f, 1.0f, 2.0f },  // BAI05
                { 1.0f, 2.5f, 1.0f, 2.0f },  // BAI06
                { 1.0f, 1.0f, 2.0f, 2.0f },  // BAI07
                { 1.0f, 1.0f, 1.0f, 2.0f },  // BAI08
                { 1.0f, 1.0f, 1.0f, 2.0f },  // BAI09
                { 1.0f, 1.5f, 1.0f, 2.0f },  // BAI10
                { 1.0f, 1.0f, 2.0f, 2.0f },  // BAI11
                { 1.0f, 3.5f, 1.0f, 3.0f },  // DSS01
                { 1.0f, 3.0f, 1.5f, 3.0f },  // DSS02
                { 1.0f, 3.0f, 1.5f, 3.5f },  // DSS03
                { 1.0f, 3.0f, 1.5f, 3.5f },  // DSS04
                { 1.5f, 2.5f, 1.5f, 3.5f },  // DSS05
                { 1.0f, 1.0f, 1.0f, 2.5f },  // DSS06
                { 1.0f, 1.0f, 1.0f, 2.0f },  // MEA01
                { 1.0f, 1.0f, 1.0f, 2.0f },  // MEA02
                { 1.0f, 1.0f, 1.0f, 1.5f },  // MEA03
                { 1.0f, 1.0f, 1.0f, 2.0f }   // MEA04
            };

            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    {
                        float dsweight7 = weights7[i, j];
                        _builder.Entity<MapModel>().HasData(
                        new MapModel { ObjectiveID = i + 1, QuestionID = j + 62, Weight = dsweight7 }
                        );
                    }
                }
            }
        }

        public void generateMapDF8()
        {
            /// Mapping 3 Questions and 40 Objectives with their weights for design factor 8
            float[,] weights8 = new float[,]
            {
                { 1.0f, 1.0f, 1.0f },  // EDM01
                { 1.0f, 1.0f, 1.0f },  // EDM02
                { 1.0f, 2.0f, 1.0f },  // EDM03
                { 1.0f, 1.0f, 1.0f },  // EDM04
                { 1.0f, 1.0f, 1.0f },  // EDM05
                { 1.0f, 1.0f, 1.0f },  // APO01
                { 1.0f, 1.0f, 1.0f },  // APO02
                { 1.0f, 1.0f, 1.0f },  // APO03
                { 1.0f, 1.0f, 1.0f },  // APO04
                { 1.0f, 1.0f, 1.0f },  // APO05
                { 1.0f, 1.0f, 1.0f },  // APO06
                { 1.0f, 1.0f, 1.0f },  // APO07
                { 1.0f, 1.0f, 1.0f },  // APO08
                { 4.0f, 4.0f, 1.0f },  // APO09
                { 4.0f, 4.0f, 1.0f },  // APO10
                { 1.0f, 1.0f, 1.0f },  // APO11
                { 2.0f, 2.0f, 1.0f },  // APO12
                { 1.0f, 1.0f, 1.0f },  // APO13
                { 1.0f, 1.0f, 1.0f },  // APO14
                { 1.0f, 1.0f, 1.0f },  // BAI01
                { 1.0f, 1.0f, 1.0f },  // BAI02
                { 1.0f, 1.0f, 1.0f },  // BAI03
                { 1.0f, 1.0f, 1.0f },  // BAI04
                { 1.0f, 1.0f, 1.0f },  // BAI05
                { 1.0f, 1.0f, 1.0f },  // BAI06
                { 1.0f, 1.0f, 1.0f },  // BAI07
                { 1.0f, 1.0f, 1.0f },  // BAI08
                { 1.0f, 1.0f, 1.0f },  // BAI09
                { 1.0f, 1.0f, 1.0f },  // BAI10
                { 1.0f, 1.0f, 1.0f },  // BAI11
                { 1.0f, 1.0f, 1.0f },  // DSS01
                { 1.0f, 1.0f, 1.0f },  // DSS02
                { 1.0f, 1.0f, 1.0f },  // DSS03
                { 1.0f, 1.0f, 1.0f },  // DSS04
                { 1.0f, 1.0f, 1.0f },  // DSS05
                { 1.0f, 1.0f, 1.0f },  // DSS06
                { 1.0f, 1.0f, 1.0f },  // MEA01
                { 1.0f, 1.0f, 1.0f },  // MEA02
                { 1.0f, 1.0f, 1.0f },  // MEA03
                { 1.0f, 1.0f, 1.0f },  // MEA04
            };

            for (int i = 0; i < 40; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    {
                        float dsweight7 = weights8[i, j];
                        _builder.Entity<MapModel>().HasData(
                        new MapModel { ObjectiveID = i + 1, QuestionID = j + 66, Weight = dsweight7 }
                        );
                    };
                }
            }
        }

        public void generateMapDF9()
        {
            /// Mapping 3 Questions and 40 Objectives with their weights for design factor 9
            float[,] weights9 = new float[,]
            {
                { 1.0f, 1.0f, 1.0f },  // EDM01
                { 1.0f, 1.0f, 1.0f },  // EDM02
                { 1.0f, 1.0f, 1.0f },  // EDM03
                { 1.0f, 1.0f, 1.0f },  // EDM04
                { 1.0f, 1.0f, 1.0f },  // EDM05
                { 1.0f, 1.0f, 1.0f },  // APO01
                { 1.0f, 1.0f, 1.0f },  // APO02
                { 1.0f, 2.0f, 1.0f },  // APO03
                { 1.0f, 1.0f, 1.0f },  // APO04
                { 1.0f, 1.0f, 1.0f },  // APO05
                { 1.0f, 1.0f, 1.0f },  // APO06
                { 1.0f, 1.5f, 1.0f },  // APO07
                { 1.0f, 1.0f, 1.0f },  // APO08
                { 1.0f, 1.0f, 1.0f },  // APO09
                { 1.0f, 1.0f, 1.0f },  // APO10
                { 1.0f, 1.0f, 1.0f },  // APO11
                { 1.0f, 1.5f, 1.0f },  // APO12
                { 1.0f, 1.0f, 1.0f },  // APO13
                { 1.0f, 1.0f, 1.0f },  // APO14
                { 2.0f, 1.5f, 1.0f },  // BAI01
                { 3.5f, 2.0f, 1.0f },  // BAI02
                { 4.0f, 3.0f, 1.0f },  // BAI03
                { 1.0f, 1.0f, 1.0f },  // BAI04
                { 2.5f, 1.5f, 1.0f },  // BAI05
                { 3.5f, 2.0f, 1.0f },  // BAI06
                { 2.5f, 2.5f, 1.0f },  // BAI07
                { 1.0f, 1.0f, 1.0f },  // BAI08
                { 1.0f, 1.0f, 1.0f },  // BAI09
                { 1.5f, 2.0f, 1.0f },  // BAI10
                { 2.5f, 1.0f, 1.0f },  // BAI11
                { 1.0f, 2.5f, 1.0f },  // DSS01
                { 1.0f, 1.5f, 1.0f },  // DSS02
                { 1.0f, 1.5f, 1.0f },  // DSS03
                { 1.0f, 1.0f, 1.0f },  // DSS04
                { 1.0f, 1.0f, 1.0f },  // DSS05
                { 1.0f, 1.0f, 1.0f },  // DSS06
                { 1.5f, 1.5f, 1.0f },  // MEA01
                { 1.0f, 1.0f, 1.0f },  // MEA02
                { 1.0f, 1.0f, 1.0f },  // MEA03
                { 1.0f, 1.0f, 1.0f }   // MEA04
            };

            for (int i = 0; i < 40; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    {
                        float dsweight7 = weights9[i, j];

                        _builder.Entity<MapModel>().HasData(
                        new MapModel { ObjectiveID = i + 1, QuestionID = j + 69, Weight = dsweight7 }
                        );
                    };
                }
            }
        }

        public void generateMapDF10()
        {
            /// Mapping 3 Questions and 40 Objectives with their weights for design factor 10
            float[,] weights10 = new float[,]
            {
                { 3.5f, 2.5f, 1.5f },  // EDM01
                { 4.0f, 2.5f, 1.5f },  // EDM02
                { 1.5f, 1.0f, 1.0f },  // EDM03
                { 2.5f, 2.0f, 1.5f },  // EDM04
                { 1.5f, 1.0f, 1.0f },  // EDM05
                { 2.5f, 1.5f, 1.0f },  // APO01
                { 4.0f, 3.0f, 1.5f },  // APO02
                { 2.0f, 1.0f, 1.0f },  // APO03
                { 4.0f, 3.0f, 1.0f },  // APO04
                { 4.0f, 2.5f, 1.0f },  // APO05
                { 1.0f, 1.5f, 1.0f },  // APO06
                { 2.5f, 1.0f, 1.0f },  // APO07
                { 3.0f, 1.5f, 1.0f },  // APO08
                { 1.5f, 1.5f, 1.0f },  // APO09
                { 2.5f, 1.5f, 1.0f },  // APO10
                { 1.5f, 1.5f, 1.0f },  // APO11
                { 2.0f, 1.5f, 1.0f },  // APO12
                { 1.0f, 1.0f, 1.0f },  // APO13
                { 2.5f, 2.0f, 1.0f },  // APO14
                { 4.0f, 3.0f, 1.5f },  // BAI01
                { 3.5f, 2.5f, 1.0f },  // BAI02
                { 4.0f, 2.5f, 1.0f },  // BAI03
                { 1.5f, 1.5f, 1.0f },  // BAI04
                { 3.0f, 2.0f, 1.0f },  // BAI05
                { 2.5f, 2.0f, 1.0f },  // BAI06
                { 3.5f, 2.5f, 1.0f },  // BAI07
                { 1.5f, 1.0f, 1.0f },  // BAI08
                { 1.0f, 1.0f, 1.0f },  // BAI09
                { 1.5f, 1.0f, 1.0f },  // BAI10
                { 3.5f, 2.5f, 1.0f },  // BAI11
                { 1.0f, 1.0f, 1.0f },  // DSS01
                { 1.0f, 1.0f, 1.0f },  // DSS02
                { 1.5f, 1.0f, 1.0f },  // DSS03
                { 1.5f, 1.0f, 1.0f },  // DSS04
                { 1.5f, 1.0f, 1.0f },  // DSS05
                { 1.0f, 1.0f, 1.0f },  // DSS06
                { 3.0f, 2.0f, 1.0f },  // MEA01
                { 1.0f, 1.0f, 1.0f },  // MEA02
                { 1.0f, 1.0f, 1.0f },  // MEA03
                { 1.0f, 1.0f, 1.0f }   // MEA04
            };

            for (int i = 0; i < 40; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    {
                        float dsweight7 = weights10[i, j];

                        _builder.Entity<MapModel>().HasData(
                        new MapModel { ObjectiveID = i + 1, QuestionID = j + 72, Weight = dsweight7 }
                        );
                    }
                }
            }
        }
    }
}
