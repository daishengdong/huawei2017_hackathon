//#include "stm32f10x.h"
#include "CONFIG.h"
#include "stm32f10x_nvic.h"
//#include"stm32f10x_flash.h"
/**************
*clock config
*******************/
void RCC_Configuration(void)
{
	//SystemInit();
	ErrorStatus	HSEStartUpStatus;
	RCC_DeInit();
	//
	RCC_HSEConfig(RCC_HSE_ON);
	HSEStartUpStatus=RCC_WaitForHSEStartUp();
	if(HSEStartUpStatus==SUCCESS){
		//配置PLL时钟 == 外部高速晶体时钟*9
		RCC_PLLConfig(RCC_PLLSource_HSE_Div1, RCC_PLLMul_9); 
		//启动FLASH预取值
		//FLASH_PrefetchBufferCmd(FLASH_PrefetchBuffer_Enable);
		//设置FLASH_Lacency延时2周期
		//FLASH_SetLatency(FLASH_Latency_2);

   		//配置AHB(HCLK)时钟=SYSCLK
		RCC_HCLKConfig(RCC_SYSCLK_Div1);

    	//配置APB2(PCLK2)钟=AHB时钟
		RCC_PCLK1Config(RCC_HCLK_Div2);

    	//配置APB1(PCLK1)钟=AHB 1/2时钟
		RCC_PCLK2Config(RCC_HCLK_Div1);

   		//配置ADC时钟=PCLK2 1/4
		RCC_ADCCLKConfig(RCC_PCLK2_Div4);



		//使能PLL
		RCC_PLLCmd(ENABLE);

		//等待PLL时钟就绪
		while(RCC_GetFlagStatus(RCC_FLAG_PLLRDY)==RESET)
		{
		}
		//SYSCLK = PLL
		RCC_SYSCLKConfig(RCC_SYSCLKSource_PLLCLK);
		//检查PLL时钟是否为SYSCLK
		while(RCC_GetSYSCLKSource() != 0x08)
		{
		}
	}	 
	RCC_APB1PeriphClockCmd(RCC_APB1Periph_TIM2|RCC_APB1Periph_TIM3,ENABLE);//|RCC_APB1Periph_USART2
	RCC_APB2PeriphClockCmd(RCC_APB2Periph_SPI1|RCC_APB2Periph_USART1|RCC_APB2Periph_GPIOA|RCC_APB2Periph_GPIOB|
													RCC_APB2Periph_GPIOC|RCC_APB2Periph_GPIOD,ENABLE);
	GPIO_PinRemapConfig(GPIO_Remap_SWJ_JTAGDisable,DISABLE);//stop JATG
}


/***************
*irq config

*
************************/
void NVIC_Config(void) 
{ 
    NVIC_InitTypeDef NVIC_InitStructure; 				 
    NVIC_PriorityGroupConfig(NVIC_PriorityGroup_0); 	 //设置优先级分组：先占优先级和从优先级
    NVIC_InitStructure.NVIC_IRQChannel=USART2_IRQChannel;          //通道 使能或者失能指定的IRQ 通道
    NVIC_InitStructure.NVIC_IRQChannelPreemptionPriority=0;// 该参数设置了成员NVIC_IRQChannel  中的先占优先级
    NVIC_InitStructure.NVIC_IRQChannelSubPriority=0; //   该参数设置了成员NVIC_IRQChannel  中的从优先级
    NVIC_InitStructure.NVIC_IRQChannelCmd=ENABLE; 		 //通道开启
    NVIC_Init(&NVIC_InitStructure); 
} 

