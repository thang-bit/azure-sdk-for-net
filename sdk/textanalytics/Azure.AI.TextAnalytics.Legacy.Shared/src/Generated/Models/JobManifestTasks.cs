// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Legacy
{
    /// <summary> The set of tasks to execute on the input documents. Cannot specify the same task more than once. </summary>
    internal partial class JobManifestTasks
    {
        /// <summary> Initializes a new instance of <see cref="JobManifestTasks"/>. </summary>
        public JobManifestTasks()
        {
            EntityRecognitionTasks = new ChangeTrackingList<EntitiesTask>();
            EntityRecognitionPiiTasks = new ChangeTrackingList<PiiTask>();
            KeyPhraseExtractionTasks = new ChangeTrackingList<KeyPhrasesTask>();
            EntityLinkingTasks = new ChangeTrackingList<EntityLinkingTask>();
            SentimentAnalysisTasks = new ChangeTrackingList<SentimentAnalysisTask>();
        }

        /// <summary> Initializes a new instance of <see cref="JobManifestTasks"/>. </summary>
        /// <param name="entityRecognitionTasks"></param>
        /// <param name="entityRecognitionPiiTasks"></param>
        /// <param name="keyPhraseExtractionTasks"></param>
        /// <param name="entityLinkingTasks"></param>
        /// <param name="sentimentAnalysisTasks"></param>
        internal JobManifestTasks(IList<EntitiesTask> entityRecognitionTasks, IList<PiiTask> entityRecognitionPiiTasks, IList<KeyPhrasesTask> keyPhraseExtractionTasks, IList<EntityLinkingTask> entityLinkingTasks, IList<SentimentAnalysisTask> sentimentAnalysisTasks)
        {
            EntityRecognitionTasks = entityRecognitionTasks;
            EntityRecognitionPiiTasks = entityRecognitionPiiTasks;
            KeyPhraseExtractionTasks = keyPhraseExtractionTasks;
            EntityLinkingTasks = entityLinkingTasks;
            SentimentAnalysisTasks = sentimentAnalysisTasks;
        }
    }
}
