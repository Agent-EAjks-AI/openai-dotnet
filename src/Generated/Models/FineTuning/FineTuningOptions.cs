// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using OpenAI;

namespace OpenAI.FineTuning
{
    [Experimental("OPENAI001")]
    public partial class FineTuningOptions
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal FineTuningOptions(string model, string trainingFile, HyperparameterOptions hyperparameters, string suffix, string validationFile, IList<FineTuningIntegration> integrations, int? seed, FineTuningTrainingMethod trainingMethod, IDictionary<string, string> metadata, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            // Plugin customization: ensure initialization of collections
            Model = model;
            TrainingFile = trainingFile;
            Hyperparameters = hyperparameters;
            Suffix = suffix;
            ValidationFile = validationFile;
            Integrations = integrations ?? new ChangeTrackingList<FineTuningIntegration>();
            Seed = seed;
            TrainingMethod = trainingMethod;
            Metadata = metadata ?? new ChangeTrackingDictionary<string, string>();
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
