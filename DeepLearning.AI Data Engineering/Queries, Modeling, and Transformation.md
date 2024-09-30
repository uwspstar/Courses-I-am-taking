### Summary:

The transformation stage is a crucial part of the data engineering lifecycle where the data engineer starts adding significant value to the raw data. In the previous stage, ingesting and storing raw data doesn’t provide much value to downstream stakeholders like business analysts or data scientists. Transformation involves converting raw data into a more useful form, making it accessible and ready for end-users. This stage is essential for making data suitable for various use cases, including business reporting and machine learning model training.

In the transformation stage, there are three key components:
1. **Queries**: Used to read and manipulate data from storage systems. Well-written queries are crucial for performance and avoiding issues like row explosion or performance degradation.
2. **Data Modeling**: Involves structuring data in a way that reflects the real world and the business's needs, making it easier for stakeholders to understand and use the data.
3. **Transformation**: Manipulating and enhancing the data throughout its lifecycle to ensure it’s in the right format and structure for downstream use cases.

The transformation process happens at multiple points in the data lifecycle. For example, data may be transformed during ingestion, within a data pipeline, or after it's loaded into a data warehouse. Properly transforming data enables downstream users, like business analysts and data scientists, to efficiently use it for generating insights or building predictive models.

### 中文总结：

数据工程生命周期中的**数据转换阶段**是数据工程师开始为原始数据增加实际价值的关键阶段。在前一阶段（数据摄取和存储），仅仅将数据从源系统中提取并存储下来，并没有为下游的利益相关者（例如业务分析师或数据科学家）带来直接的价值。而数据转换则是将原始数据转化为更有用的形式，使其可供终端用户使用的过程。

在数据转换阶段，有三个关键组成部分：
1. **查询（Queries）**：用于从存储系统中读取和操作数据。编写良好的查询对于系统性能至关重要，能够避免行爆炸（Row Explosion）等问题，从而避免性能下降。
2. **数据建模（Data Modeling）**：通过构建数据结构，使数据更好地反映现实世界的业务需求，并且易于利益相关者理解和使用。
3. **数据转换（Transformation）**：在数据生命周期的多个阶段对数据进行操作和增强，以确保数据格式和结构能够满足下游应用场景的需求。

数据转换过程贯穿于数据生命周期的多个阶段。例如，数据可能在数据摄取时、数据管道中或在加载到数据仓库后进行转换。正确的数据转换能够使下游用户（如业务分析师和数据科学家）更有效地使用数据，从而生成有价值的洞见或构建预测模型。

这一阶段不仅仅是对数据进行简单的转换，还包括数据的清理、归一化和标准化处理，确保数据的完整性和一致性，以便为下游的分析和建模提供高质量的数据支持。
