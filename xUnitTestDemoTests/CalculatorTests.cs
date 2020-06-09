using Xunit;
using Xunit.Abstractions;

namespace xUnitTestDemo.Tests
{
    [Trait("测试目录-Class", "单元测试-Class")]
    public class CalculatorTests
    {
        private readonly ITestOutputHelper outputHelper;

        public CalculatorTests(ITestOutputHelper outputHelper)
        {
            this.outputHelper = outputHelper;
        }

        /// <summary>
        /// 使用 [Fact] 标记方法为单元测试方法，可以使用 Skip 和 Timeout 参数设置跳过或超时
        /// 使用 [Trait] 标记单元测试的分组特征，在 测试资源管理器窗口>分组依据 勾选特征
        /// </summary>
        [Fact()]
        [Trait("测试目录-Method", "单元测试-Method")]
        public void AddTest()
        {
            outputHelper.WriteLine("test output ...");

            // Arrange
            var sut = new Calculator();// System under test

            // Act
            var result = sut.Add(1, 2);

            // Assert
            Assert.Equal(3, result);
        }
    }
}