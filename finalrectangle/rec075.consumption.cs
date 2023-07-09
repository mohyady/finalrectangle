﻿// This file was auto-generated by ML.NET Model Builder. 
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace Finalrectangle
{
    public partial class Rec075
    {
        /// <summary>
        /// model input class for Rec075.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [ColumnName(@"x")]
            public float X { get; set; }

            [ColumnName(@"y")]
            public float Y { get; set; }

            [ColumnName(@"omega")]
            public float Omega { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for Rec075.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            [ColumnName(@"x")]
            public float X { get; set; }

            [ColumnName(@"y")]
            public float Y { get; set; }

            [ColumnName(@"omega")]
            public float Omega { get; set; }

            [ColumnName(@"Features")]
            public float[] Features { get; set; }

            [ColumnName(@"Score")]
            public float Score { get; set; }

        }

        #endregion

        private static string MLNetModelPath = Path.GetFullPath("rec075.zip");

        public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);

        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input);
        }

        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }
    }
}
